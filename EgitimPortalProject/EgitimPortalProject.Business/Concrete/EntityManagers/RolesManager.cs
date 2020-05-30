using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortalProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class RolesManager : IRolesService
    {
        private IRolesDal _rolesDal;
        private readonly IMapper _mapper;

        public RolesManager(IRolesDal rolesDal, IMapper mapper)
        {
            _rolesDal = rolesDal;
            _mapper = mapper;
        }

        public List<Roles> GetAll()
        {
            var model = _mapper.Map<List<Roles>>(_rolesDal.GetList());
            return model;
        }

        public Roles GetById(int id)
        {
            var model = _rolesDal.Get(p => p.Id == id);
            return model;
        }

        public Roles Add(Roles roles)
        {
            return _rolesDal.Add(roles);
        }

        public Roles Update(Roles roles)
        {
            return _rolesDal.Update(roles);
        }

        public void Delete(Roles roles)
        {
            _rolesDal.Delete(roles);
        }
    }
}