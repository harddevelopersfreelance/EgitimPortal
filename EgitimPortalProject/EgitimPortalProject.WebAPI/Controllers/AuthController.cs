using EgitimPortalProject.Business.Abstract;
using EgitimPortalProject.Business.ObjectDtos.UserDtos;
using EgitimPortalProject.Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgitimPortalProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController:Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("loginAuth")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (userToLogin == null)
            {
                return BadRequest();
            }

            var result = _authService.CreateAccessToken(userToLogin);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest((AccessToken)null);
        }
        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists)
                return BadRequest(false);

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult);
            if (result == null)
            {
                return Ok((AccessToken)null);
            }

            return BadRequest(error: result);
        }
    }
}
