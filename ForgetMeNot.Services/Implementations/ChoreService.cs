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

        public async Task<ChoreDto> GetById(int id)
        {
            using (var ctx = _context)
            {
                var chore = await ctx.Chores.FirstOrDefaultAsync(c => c.Id == id);
                var isChoreCompleted =
                    await ctx.CompletedChores.LastOrDefaultAsync(cc =>
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

        public async Task<IEnumerable<ChoreDto>> GetAll()
        {
            using (var ctx = _context)
            {
                var chores = await Task.WhenAll(ctx.Chores.Where(c =>
                        (int) DateTime.Now.Subtract(c.CreatedAt).TotalDays % c.IntervalInDays == 0
                    )
                    .AsEnumerable().Select(async chore =>
                    {
                        var isChoreCompleted =
                            await ctx.CompletedChores.LastOrDefaultAsync(cc =>
                                cc.ChoreId == chore.Id && cc.CreatedAt.Date == DateTime.Today);
                        return new ChoreDto
                        {
                            Id = chore.Id,
                            Title = chore.Title,
                            CreatedAt = chore.CreatedAt,
                            IsCompleted = isChoreCompleted != null,
                            PlantId = chore.PlantId,
                            IntervalInDays = chore.IntervalInDays
                        };
                    }));
                return chores;
            }
        }

        public async Task<bool> Save(ChoreDto dto)
        {
            using (var ctx = _context)
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
                }

                if (dto.IsCompleted && dto.Id != null)
                {
                    var exist = await ctx.CompletedChores.AnyAsync(cc =>
                        cc.CreatedAt.Date == DateTime.Today && cc.ChoreId == dto.Id);
                    if (!exist)
                    {
                        await ctx.CompletedChores.AddAsync(new CompletedChore
                        {
                            Title = dto.Title,
                            ChoreId = (int) dto.Id,
                            CreatedAt = DateTime.Now,
                            PlantId = dto.PlantId
                        });
                    }
                }

                ctx.Entry(entity).State = dto.Id != null ? EntityState.Modified : EntityState.Added;
                var result = await ctx.SaveChangesAsync();
                return result > 0;
            }
        }

        public async Task<bool> Remove(int id)
        {
            using (var ctx = _context)
            {
                var entity = await ctx.Chores.FirstOrDefaultAsync(c => c.Id == id);
                if (entity != null)
                {
                    ctx.Chores.Remove(entity);
                }
                var result = await ctx.SaveChangesAsync();
                return result > 0;
            }
        }
    }
}