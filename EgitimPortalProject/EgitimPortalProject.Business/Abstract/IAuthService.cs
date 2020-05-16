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
        User Register(UserForRegisterDto userForRegisterDto, string password);

        User Login(UserForLoginDto userForLoginDto);

        bool UserExists(string email);

        AccessToken CreateAccessToken(User user);
    }
}
