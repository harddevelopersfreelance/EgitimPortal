using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class UserRolesManager : IUserRolesService
    {
        private IUserRolesDal _userrolesDal;
        private readonly IMapper _mapper;

        public UserRolesManager(IUserRolesDal userrolesDal, IMapper mapper)
        {
            _userrolesDal = userrolesDal;
            _mapper = mapper;
        }

         
         
        public List<UserRoles> GetAll()
        {
            var model = _mapper.Map<List<UserRoles>>(_userrolesDal.GetList());
            return model;
        }

         
         
        public UserRoles GetById(int id)
        {
            var model = _userrolesDal.Get(p => p.UserRoleId == id);
            return model;
        }

         
         
        public UserRoles Add(UserRoles userroles)
        {
            return _userrolesDal.Add(userroles);
        }

         
         
        public UserRoles Update(UserRoles userroles)
        {
            return _userrolesDal.Update(userroles);
        }

         
         
        public void Delete(UserRoles userroles)
        {
            _userrolesDal.Delete(userroles);
        }

         
         
        /// Tablosu ile olan Foreign Key Column UserId
        public List<UserRoles> GetListByUserID(int userid)
        {
            var model = _userrolesDal.GetList(p => p.UserId == userid);
            return model;
        }

         
         
        /// Tablosu ile olan Foreign Key Column OperationClaimId
        public List<UserRoles> GetListByRoleIdID(int operationclaimid)
        {
            var model = _userrolesDal.GetList(p => p.RoleId == operationclaimid);
            return model;
        }
 
  
    }
}