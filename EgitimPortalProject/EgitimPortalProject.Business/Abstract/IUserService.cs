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

        User UserActivate(Guid activateId);

        User GetUserByInfo(string email, string userName);
        User GetByMail(string email);
        List<Role> GetClaims(User user);
        void Add(User user);

    }
}
