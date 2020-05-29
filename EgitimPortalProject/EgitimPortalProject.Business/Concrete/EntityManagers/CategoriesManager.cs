using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class CategoriesManager : ICategoriesService
    {
        private ICategoriesDal _categoriesDal;
        private readonly IMapper _mapper;

        public CategoriesManager(ICategoriesDal categoriesDal, IMapper mapper)
        {
            _categoriesDal = categoriesDal;
            _mapper = mapper;
        }

         
         
        public List<Categories> GetAll()
        {
            var model = _mapper.Map<List<Categories>>(_categoriesDal.GetList());
            return model;
        }

         
         
        public Categories GetById(int id)
        {
            var model = _categoriesDal.Get(p => p.FlagId == id);
            return model;
        }

         
         
        public Categories Add(Categories categories)
        {
            return _categoriesDal.Add(categories);
        }

         
         
        public Categories Update(Categories categories)
        {
            return _categoriesDal.Update(categories);
        }

         
         
        public void Delete(Categories categories)
        {
            _categoriesDal.Delete(categories);
        }
    }
}