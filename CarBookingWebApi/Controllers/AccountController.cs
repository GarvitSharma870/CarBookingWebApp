using AutoMapper;
using DAL.DTO;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarBookingWebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;
        public AccountController(UserManager<User> userManager, IConfiguration config, IMapper mapper)
        {
            this._userManager = userManager;
            _config = config;
            this._mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDTO model)
        {
            try
            {
                var user = _mapper.Map<User>(model);
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                    return StatusCode(201, new { message = "User Registered Successfully" });
                }
                else
                {
                    return StatusCode(409, new { message = "User Already Exists" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, (new { message = ex.Message }));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User user = await _userManager.FindByEmailAsync(model.Email);
                    if (user != null)
                    {

                        if (!await _userManager.CheckPasswordAsync(user, model.Password))
                        {
                            return Unauthorized(new { message = "Invalid Credentials" });
                        }
                        var accessToken = GenerateToken(user);
                        return Ok(new { message = "User Logged-in Successfully!", token = accessToken });
                    }
                    else
                    {
                        return NotFound(new { message = "User does n't exist" });
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = "Internal server error" });
                }
            }
            return BadRequest(new { message = "Validation errors" });
        }
        private string GenerateToken(User user)
        {
            List<string> roles = _userManager.GetRolesAsync(user).Result.ToList();
            var claims = new[] {
            new Claim("name", user.Name),
            new Claim("nameidentifier", user.Id),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("email", user.Email),
            new Claim("role", roles[0]),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims,
                expires: DateTime.Now.AddHours(1), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
