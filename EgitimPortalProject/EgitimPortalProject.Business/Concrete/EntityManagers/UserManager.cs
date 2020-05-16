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
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        { 
            var data = _userDal.Get((u => u.Email == email));
            return data;
        }

        public List<Role> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public User GetUserByInfo(string email, string userName)
        {
            throw new NotImplementedException();
        }

        public bool IsUserCheck(string email, string userName)
        {
            throw new NotImplementedException();
        }

        public User UserActivate(Guid activateId)
        {
            throw new NotImplementedException();
        }
    }
}
