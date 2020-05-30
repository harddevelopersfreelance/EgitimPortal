using EgitimPortalProject.Business.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace EgitimPortalProject.Business.Concrete.EntityManagers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Users Add(Users user)
        {
            return _userDal.Add(user);
        }

        public void Delete(Users users)
        {
            _userDal.Delete(users);
        }

        public List<Users> GetAll()
        {
            return _userDal.GetList();
        }

        public Users GetById(int id)
        {
            return _userDal.Get(c => c.Id == id);
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

        public List<Users> GetListByGenderId(int genderid)
        {
            //ling dalda yazılacak
            throw new NotImplementedException();
        }

        public List<Users> GetListByLanguageId(int languageid)
        {
            //ling dalda yazılacak
            throw new NotImplementedException();
        }

        public Users GetUserByInfo(string email, string userName)
        {
            throw new NotImplementedException();
        }

        public bool IsUserCheck(string email, string userName)
        {
            throw new NotImplementedException();
        }

        public Users Update(Users users)
        {
            throw new NotImplementedException();
        }

        public Users UserActivate(Guid activateId)
        {
            throw new NotImplementedException();
        }
    }
}