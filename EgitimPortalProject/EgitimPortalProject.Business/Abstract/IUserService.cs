using EgitimPortalProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace EgitimPortalProject.Business.Abstract
{
    public interface IUserService
    {
        List<Users> GetAll();

        Users GetById(int id);

        Users Update(Users users);

        void Delete(Users users);

        List<Users> GetListByGenderID(int genderid);

        List<Users> GetListByLanguageID(int languageid);

        bool IsUserCheck(string email, string userName);

        Users UserActivate(Guid activateId);

        Users GetUserByInfo(string email, string userName);

        Users GetByMail(string email);

        List<Roles> GetClaims(Users user);

        Users Add(Users user);
    }
}