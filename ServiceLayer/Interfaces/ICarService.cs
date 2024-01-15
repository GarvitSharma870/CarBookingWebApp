using DAL.DTO;
using DAL.Entities;
using DAL.Repository;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface ICarService
    {
        Task<List<Car>> GetCarsByUserId(string userId);
        Task<List<Car>> GetCarsByCompanyId(int id);
    }
}
