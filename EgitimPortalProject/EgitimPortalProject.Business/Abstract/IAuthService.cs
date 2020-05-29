using EgitimPortalProject.Business.ObjectDtos.UserDtos;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Business.Abstract
{
public    interface IAuthService
    {
        Users Register(UserForRegisterDto userForRegisterDto, string password);

        Users Login(UserForLoginDto userForLoginDto);

        bool UserExists(string email);

        AccessToken CreateAccessToken(Users user);
    }
}
