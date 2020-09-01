using System.Collections.Generic;
using ForgetMeNot.DAL.Model;

namespace ForgetMeNot.Services.Interfaces
{
    public interface IPlantService
    {
        IEnumerable<Plant> GetAll();
        Plant GetById(int id);
        bool Save(Plant plant);
        bool Remove(Plant plant);
    }
}