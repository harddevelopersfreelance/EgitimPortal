using EgitimPortalProject.Business.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Business.Concrete.EntityManagers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(Users user)
        {
            _userDal.Add(user);
        }

        public Users GetByMail(string email)
        { 
            var data = _userDal.Get((u => u.Email == email));
            return data;
        }

        public List<Roles> GetClaims(Users user)
        {
            return _userDal.GetClaims(user);
        }

        public Users GetUserByInfo(string email, string userName)
        {
            throw new NotImplementedException();
        }

        public bool IsUserCheck(string email, string userName)
        {
            throw new NotImplementedException();
        }

        public Users UserActivate(Guid activateId)
        {
            throw new NotImplementedException();
        }
    }
}
