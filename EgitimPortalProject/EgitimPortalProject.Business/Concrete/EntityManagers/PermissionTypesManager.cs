using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class PermissionTypesManager : IPermissionTypesService
    {
        private IPermissionTypesDal _permissiontypesDal;
        private readonly IMapper _mapper;

        public PermissionTypesManager(IPermissionTypesDal permissiontypesDal, IMapper mapper)
        {
            _permissiontypesDal = permissiontypesDal;
            _mapper = mapper;
        }

         
         
        public List<PermissionTypes> GetAll()
        {
            var model = _mapper.Map<List<PermissionTypes>>(_permissiontypesDal.GetList());
            return model;
        }

         
         
        public PermissionTypes GetById(int id)
        {
            var model = _permissiontypesDal.Get(p => p.id == id);
            return model;
        }

         
         
        public PermissionTypes Add(PermissionTypes permissiontypes)
        {
            return _permissiontypesDal.Add(permissiontypes);
        }

         
         
        public PermissionTypes Update(PermissionTypes permissiontypes)
        {
            return _permissiontypesDal.Update(permissiontypes);
        }

         
         
        public void Delete(PermissionTypes permissiontypes)
        {
            _permissiontypesDal.Delete(permissiontypes);
        }
    }
}