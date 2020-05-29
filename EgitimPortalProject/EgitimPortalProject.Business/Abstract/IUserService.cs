using EgitimPortalProject.Business.ObjectDtos.UserDtos;
using EgitimPortalProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Business.Abstract
{
    public interface IUserService
    {
     

        bool IsUserCheck(string email, string userName);

        Users UserActivate(Guid activateId);

        Users GetUserByInfo(string email, string userName);
        Users GetByMail(string email);
        List<Roles> GetClaims(Users user);
        void Add(Users user);

    }
}
