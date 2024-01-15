using AutoMapper;
using DAL.DTO;
using DAL.Entities;
using DAL.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ServiceLayer.Interfaces;
using System.Security.Claims;
using TimeZone = DAL.Entities.TimeZone;

namespace CarBookingWebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class CarController : ControllerBase
    {
        private IMapper _mapper;
        private IGenericRepository<Car> _carGenericRepository;
        private IGenericRepository<TimeZone> _timezoneGenericRepository;
        private ICarService _carService;
        public CarController(IGenericRepository<TimeZone> timezoneGenericRepository,IGenericRepository<Car> carGenericRepository, ICarService carService, IMapper mapper)
        {
            _carGenericRepository = carGenericRepository;
            _carService = carService;
            _mapper = mapper;
            _timezoneGenericRepository = timezoneGenericRepository;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllTimeZones()
        {
            try
            {
                List<TimeZone> timezones = _timezoneGenericRepository.GetAll().Result.ToList();
                if (timezones.Count == 0)
                {
                    return NotFound(new { message = "No TimeZones Found" });
                }
                return Ok(timezones);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            try
            {
                List<Car> cars = _carGenericRepository.GetAll().Result.Where(x=>x.IsDeleted == false).ToList();
                if (cars.Count == 0)
                {
                    return NotFound(new { message = "No Cars Found" });
                }
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            try
            {
                Car car = await _carGenericRepository.GetById(id);
                if (car == null)
                {
                    return NotFound(new { message = "No Car Found" });
                }
                return Ok(car);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetCarByUserId()
        {
            try
            {
                string UserId = User.FindFirstValue("nameidentifier");
                List<Car> cars = await _carService.GetCarsByUserId(UserId);
                if (cars.Count == 0)
                {
                    return NotFound(new { message = "No Car Found" });
                }
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarsByCompanyId(int id)
        {
            try
            {
                List<Car> cars = await _carService.GetCarsByCompanyId(id);
                if (cars.Count == 0)
                {
                    return NotFound(new { message = "No Car Found" });
                }
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(CarDTO model)
        {
            try
            {
                Car car = _mapper.Map<Car>(model);
                car.AvailabilityFrom = ConvertDateToUTC(model.AvailableTime[0], model.Offset);
                car.AvailabilityTo = ConvertDateToUTC(model.AvailableTime[1], model.Offset);
                car.CreatedOn = DateTime.UtcNow;
                car.CreatedBy = User.FindFirstValue("nameidentifier");
                car.UserId = car.CreatedBy;
                car.IsActive = true;
                await _carGenericRepository.Insert(car);
                await _carGenericRepository.Save();
                return Ok(new { message = "Car Created Successfully" });
            }
            catch (Exception ex)
            {
                if (ex?.InnerException is SqlException sqlException &&
                   (sqlException.Number == 2601 || sqlException.Number == 2627))
                {
                    return StatusCode(500, new { message = $"Car with this name and number already exist" });
                }
                else
                {
                    return BadRequest(new { message = ex.Message });
                }
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CarDTO model)
        {
            try
            {
                Car exist = await _carGenericRepository.GetById(id);
                if (exist == null)
                {
                    return NotFound(new { message = "Car Not Found" });
                }
                string userId = User.FindFirstValue("nameidentifier");
                Car car = _mapper.Map<Car>(model);
                car.Id = id;
                car.AvailabilityFrom = ConvertDateToUTC(model.AvailableTime[0], model.Offset);
                car.AvailabilityTo = ConvertDateToUTC(model.AvailableTime[1], model.Offset);
                car.UpdatedOn = DateTime.UtcNow;
                car.UpdatedBy = userId;
                car.CreatedOn = exist.CreatedOn;
                car.CreatedBy = exist.CreatedBy;
                car.UserId = exist.UserId;
                if(car.Slots > 0)
                {
                    car.IsActive = true;
                }
                await _carGenericRepository.Update(car, id);
                await _carGenericRepository.Save();
                return Ok(new { message = "Car Details Updated Successfully" });
            }
            catch (Exception ex)
            {
                if (ex?.InnerException is SqlException sqlException &&
                   (sqlException.Number == 2601 || sqlException.Number == 2627))
                {
                    return StatusCode(500, new { message = $"Car with this name and number already exist" });
                }
                else
                {
                    return BadRequest(new { message = ex.Message });
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest(new { message = "Id is required" });
            }
            try
            {
                Car exist = await _carGenericRepository.GetById(id);
                if(exist.Bookings.Count > 0)
                {
                    return BadRequest(new { message = $"{exist.CarName} is currently booked." });
                }
                exist.IsDeleted = true;
                await _carGenericRepository.Update(exist, id);
                await _carGenericRepository.Save();
                return Ok(new { message = "Car Detail Deleted Successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        private DateTime ConvertDateToUTC(DateTime dateTime, int offset)
        {
            return dateTime.AddMinutes(offset);
        }

    }
}
