using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForgetMeNot.DAL.Model;
using ForgetMeNot.Services.Dto;

namespace ForgetMeNot.Services.Interfaces
{
    public interface IChoreService
    {
        ChoreDto GetById(int id);
        IEnumerable<ChoreDto> GetAll();
        bool Save(ChoreDto dto);
        bool Remove(int id);
    }
}