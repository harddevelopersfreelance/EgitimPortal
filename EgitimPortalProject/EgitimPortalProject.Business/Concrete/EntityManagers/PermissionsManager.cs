using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class PermissionsManager : IPermissionsService
    {
        private IPermissionsDal _permissionsDal;
        private readonly IMapper _mapper;

        public PermissionsManager(IPermissionsDal permissionsDal, IMapper mapper)
        {
            _permissionsDal = permissionsDal;
            _mapper = mapper;
        }

        public List<Permissions> GetAll()
        {
            var model = _mapper.Map<List<Permissions>>(_permissionsDal.GetList());
            return model;
        }

        public Permissions GetById(int id)
        {
            var model = _permissionsDal.Get(p => p.Id == id);
            return model;
        }

        public Permissions Add(Permissions permissions)
        {
            return _permissionsDal.Add(permissions);
        }

        public Permissions Update(Permissions permissions)
        {
            return _permissionsDal.Update(permissions);
        }

        public void Delete(Permissions permissions)
        {
            _permissionsDal.Delete(permissions);
        }

        /// Tablosu ile olan Foreign Key Column PermissionTypeId
        public List<Permissions> GetListByPermissionTypeId(int permissiontypeid)
        {
            var model = _permissionsDal.GetList(p => p.PermissionTypeId == permissiontypeid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column RoleId
        public List<Permissions> GetListByRoleId(int roleid)
        {
            var model = _permissionsDal.GetList(p => p.RoleId == roleid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column UserId
        public List<Permissions> GetListByUserId(int userid)
        {
            var model = _permissionsDal.GetList(p => p.UserId == userid);
            return model;
        }
    }
}