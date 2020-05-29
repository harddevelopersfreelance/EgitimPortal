using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class LessonCategoriesManager : ILessonCategoriesService
    {
        private ILessonCategoriesDal _lessoncategoriesDal;
        private readonly IMapper _mapper;

        public LessonCategoriesManager(ILessonCategoriesDal lessoncategoriesDal, IMapper mapper)
        {
            _lessoncategoriesDal = lessoncategoriesDal;
            _mapper = mapper;
        }

         
         
        public List<LessonCategories> GetAll()
        {
            var model = _mapper.Map<List<LessonCategories>>(_lessoncategoriesDal.GetList());
            return model;
        }

         
         
        public LessonCategories GetById(int id)
        {
            var model = _lessoncategoriesDal.Get(p => p.LessonCategoryId == id);
            return model;
        }

         
         
        public LessonCategories Add(LessonCategories lessoncategories)
        {
            return _lessoncategoriesDal.Add(lessoncategories);
        }

         
         
        public LessonCategories Update(LessonCategories lessoncategories)
        {
            return _lessoncategoriesDal.Update(lessoncategories);
        }

         
         
        public void Delete(LessonCategories lessoncategories)
        {
            _lessoncategoriesDal.Delete(lessoncategories);
        }

         
         
        /// Tablosu ile olan Foreign Key Column LessonID
        public List<LessonCategories> GetListByLessonID(int lessonid)
        {
            var model = _lessoncategoriesDal.GetList(p => p.LessonID == lessonid);
            return model;
        }

         
         
        /// Tablosu ile olan Foreign Key Column CategoryId
        public List<LessonCategories> GetListByCategoryID(int categoryid)
        {
            var model = _lessoncategoriesDal.GetList(p => p.CategoryId == categoryid);
            return model;
        }

        
    }
}