using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForgetMeNot.DAL.Model;
using ForgetMeNot.Services.Dto;

namespace ForgetMeNot.Services.Interfaces
{
    public interface IChoreService
    {
        Task<ChoreDto> GetById(int id);
        Task<IEnumerable<ChoreDto>> GetAll();
        Task<bool> Save(ChoreDto dto);
        Task<bool> Remove(int id);
    }
}