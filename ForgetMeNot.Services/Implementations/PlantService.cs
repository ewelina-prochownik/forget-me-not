using System.Collections.Generic;
using System.Linq;
using ForgetMeNot.DAL;
using ForgetMeNot.DAL.Model;
using ForgetMeNot.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ForgetMeNot.Services.Implementations
{
    public class PlantService: IPlantService
    {
        private readonly EfCoreContext _context;

        public PlantService(EfCoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Plant> GetAll()
        {
            return _context.Plants.AsNoTracking();
        }

        public Plant GetById(int id)
        {
            return _context.Plants.FirstOrDefault(p => p.Id == id);
        }

        public bool Save(Plant plant)
        {
            if (plant.Id > 0)
            {
                _context.Entry(plant).State = EntityState.Modified;
                _context.Entry(plant).State = EntityState.Detached;
            }
            else
            {
                _context.Plants.Add(plant);
            }
            var result = _context.SaveChanges();
            return result > 0;
        }

        public bool Remove(Plant plant)
        {
            _context.Plants.Remove(plant);
            var result = _context.SaveChanges();
            return result > 0;
        }
    }
}