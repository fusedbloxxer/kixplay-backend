using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KixPlay_Backend.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;

        public UsersController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult<string>> CreateUser([FromBody] UserRegisterDto userRegisterDto)
        {
            return Ok("test works");
        }
    }
}
