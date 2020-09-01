using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForgetMeNot.DAL;
using ForgetMeNot.DAL.Model;
using ForgetMeNot.Services.Dto;
using ForgetMeNot.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ForgetMeNot.Services.Implementations
{
    public class ChoreService : IChoreService
    {
        private readonly EfCoreContext _context;

        public ChoreService(EfCoreContext context)
        {
            _context = context;
        }

        public ChoreDto GetById(int id)
        {
            using (var ctx = _context)
            {
                var chore = ctx.Chores.FirstOrDefault(c => c.Id == id);
                var isChoreCompleted =
                    ctx.CompletedChores.AsEnumerable().LastOrDefault(cc =>
                        cc.ChoreId == id && cc.CreatedAt.Date == DateTime.Today);
                return new ChoreDto
                {
                    Id = chore.Id,
                    Title = chore.Title,
                    CreatedAt = chore.CreatedAt,
                    IsCompleted = isChoreCompleted != null,
                    PlantId = chore.PlantId,
                    IntervalInDays = chore.IntervalInDays
                };
            }
        }

        public IEnumerable<ChoreDto> GetAll()
        {
            var date = DateTime.Today;
            var chores = _context.Chores.Include(x => x.CompletedChores)
                    .AsNoTracking().AsEnumerable()
                    .Where(c =>
                        (int) DateTime.UtcNow.Subtract(c.CreatedAt).TotalDays % c.IntervalInDays == 0)
                ;

            var result = chores
                .Select(chore =>
                {
                    var completedChore = chore.CompletedChores.AsEnumerable().Any(cc =>
                        cc.ChoreId == chore.Id && cc.CreatedAt.Date == date);
                    return new ChoreDto
                    {
                        Id = chore.Id,
                        Title = chore.Title,
                        CreatedAt = chore.CreatedAt,
                        IsCompleted = completedChore,
                        PlantId = chore.PlantId,
                        IntervalInDays = chore.IntervalInDays
                    };
                }).ToList();
            return result;
        }


        public bool Save(ChoreDto dto)
        {
            var entity = new Chore
            {
                Title = dto.Title,
                CreatedAt = dto.CreatedAt,
                PlantId = dto.PlantId,
                IntervalInDays = dto.IntervalInDays
            };
            if (dto.Id != null)
            {
                entity.Id = (int) dto.Id;

                var completedChore = _context.CompletedChores.AsEnumerable()?.LastOrDefault(cc =>
                    cc.CreatedAt.Date == DateTime.Today && cc.ChoreId == dto.Id);

                if (dto.IsCompleted && completedChore == null)
                {
                    _context.CompletedChores?.Add(new CompletedChore
                    {
                        Title = dto.Title,
                        ChoreId = (int) dto.Id,
                        CreatedAt = DateTime.Now,
                        PlantId = dto.PlantId
                    });
                }
                else if (!dto.IsCompleted && completedChore != null)
                {
                    _context.CompletedChores?.Remove(completedChore);
                }

                _context.Entry<Chore>(entity).State = EntityState.Modified;
                _context.Entry<Chore>(entity).State = EntityState.Detached;
            }
            else
            {
                _context.Chores.Add(entity);
            }

            var result = _context.SaveChanges();
            return result > 0;
        }

        public bool Remove(int id)
        {
            var entity = _context.Chores.FirstOrDefault(c => c.Id == id);
            if (entity != null)
            {
                _context.Chores.Remove(entity);
            }

            var result = _context.SaveChanges();
            return result > 0;
        }
    }
}