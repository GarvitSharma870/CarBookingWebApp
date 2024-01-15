using AutoMapper;
using DAL.Context;
using DAL.DTO;
using DAL.Entities;
using DAL.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CarService : ICarService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Car> _carDetailRepository;
        public CarService(IMapper mapper, IGenericRepository<Car> carDetailRepository)
        { 
            _mapper = mapper;
            _carDetailRepository = carDetailRepository;
        }
        public async Task<List<Car>> GetCarsByUserId(string userId)
        {
            try
            {
                List<Car> cars = _carDetailRepository.GetAll().Result.Where(x => x.UserId == userId && x.IsDeleted == false).ToList();
                return cars;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Car>> GetCarsByCompanyId(int id)
        {
            try
            {
                List<Car> cars = _carDetailRepository.GetAll().Result.Where(x => x.CompanyId == id && x.IsDeleted == false).ToList();
                return cars;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
