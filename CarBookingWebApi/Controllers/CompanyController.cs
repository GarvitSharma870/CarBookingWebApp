using AutoMapper;
using DAL.Entities;
using DAL.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;

namespace CarBookingWebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class CompanyController : ControllerBase
    {
        private IMapper _mapper;
        private IGenericRepository<Company> _companyGenericRepository;
        public CompanyController(IGenericRepository<Company> companyGenericRepository, IMapper mapper)
        {
            _companyGenericRepository = companyGenericRepository;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                List<Company> companies = _companyGenericRepository.GetAll().Result.Where(x=>x.IsDeleted == false).ToList();
                if (companies.Count == 0)
                {
                    return NotFound(new { message = "No Cars Found" });
                }
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
