using AutoMapper;
using DAL.Entities;
using DAL.ModelsDTO;
using DAL.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using System.Security.Claims;

namespace CarBookingWebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class BookingController : ControllerBase
    {
        private IMapper _mapper;
        private IGenericRepository<CarBooking> _bookingGenericRepository;
        private IGenericRepository<Car> _carGenericRepository;
        public BookingController(IGenericRepository<CarBooking> bookingGenericRepository, IGenericRepository<Car> carGenericRepository, IMapper mapper)
        {
            _bookingGenericRepository = bookingGenericRepository;
            _mapper = mapper;
            _carGenericRepository = carGenericRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            try
            {
                List<CarBooking> bookings = _bookingGenericRepository.GetAll().Result.Where(x=>x.IsDeleted == false).ToList();
                if (bookings.Count == 0)
                {
                    return NotFound(new { message = "No Bookings Found" });
                }
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPost]
        public async Task<IActionResult> BookCar(BookCarDTO model)
        {
            try
            {
                Car exist = await _carGenericRepository.GetById(model.CarId);
                if (exist != null)
                {
                    CarBooking bookCar = _mapper.Map<CarBooking>(model);
                    bookCar.UserId = User.FindFirstValue("nameidentifier");
                    bookCar.BookingFrom = ConvertDateToUTC(model.BookedDuration[0], model.Offset);
                    bookCar.BookingTo = ConvertDateToUTC(model.BookedDuration[1], model.Offset);
                    bookCar.CreatedBy = bookCar.UserId;
                    bookCar.CreatedOn = DateTime.Now;
                    await _bookingGenericRepository.Insert(bookCar);
                    await _bookingGenericRepository.Save();
                    exist.Slots -= 1;
                    if (exist.Slots == 0)
                    {
                        exist.IsActive = false;
                    }
                    await _carGenericRepository.Update(exist, model.CarId);
                    await _carGenericRepository.Save();
                    return Ok(new { message = "Car Booked Successfully" });
                }
                else
                {
                    return BadRequest(new { message = "Car Not Found" });
                }
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

