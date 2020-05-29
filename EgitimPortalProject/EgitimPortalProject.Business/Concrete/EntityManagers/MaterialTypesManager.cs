using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class MaterialTypesManager : IMaterialTypesService
    {
        private IMaterialTypesDal _materialtypesDal;
        private readonly IMapper _mapper;

        public MaterialTypesManager(IMaterialTypesDal materialtypesDal, IMapper mapper)
        {
            _materialtypesDal = materialtypesDal;
            _mapper = mapper;
        }

         
         
        public List<MaterialTypes> GetAll()
        {
            var model = _mapper.Map<List<MaterialTypes>>(_materialtypesDal.GetList());
            return model;
        }

         
         
        public MaterialTypes GetById(int id)
        {
            var model = _materialtypesDal.Get(p => p.TypeId == id);
            return model;
        }

         
         
        public MaterialTypes Add(MaterialTypes materialtypes)
        {
            return _materialtypesDal.Add(materialtypes);
        }

         
         
        public MaterialTypes Update(MaterialTypes materialtypes)
        {
            return _materialtypesDal.Update(materialtypes);
        }

         
         
        public void Delete(MaterialTypes materialtypes)
        {
            _materialtypesDal.Delete(materialtypes);
        }
    }
}