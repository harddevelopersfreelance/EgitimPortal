using EgitimPortalProject.Business.Abstract;
using EgitimPortalProject.Business.Constants;
using EgitimPortalProject.Business.ObjectDtos.UserDtos;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.Core.Utilities.Hashing;
using EgitimPortalProject.Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Business.Concrete.EntityManagers
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService,ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public AccessToken CreateAccessToken(Users user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }

        public Users Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                throw new Exception(ConstMessagesTr.User_NotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new Exception(ConstMessagesTr.User_PasswordError); ;
            }
          
            return userToCheck;
        }

        public Users Register(UserForRegisterDto userForRegisterDto, string password)
        {

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new Users
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
                //Şimdilik true veriyorum. Aktivasyon olmadığı için daha sonra mail yoluyla aktivasyon yaotığımda burası status false olacak.

            };
            _userService.Add(user);
            return user;
        }

        public bool UserExists(string email)
        {

            if (_userService.GetByMail(email) != null)
            {
                return false;
            }
            return true;
        }
    }
}
