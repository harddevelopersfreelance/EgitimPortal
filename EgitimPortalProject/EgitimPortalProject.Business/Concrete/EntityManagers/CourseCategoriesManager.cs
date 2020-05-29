using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class CourseCategoriesManager : ICourseCategoriesService
    {
        private ICourseCategoriesDal _coursecategoriesDal;
        private readonly IMapper _mapper;

        public CourseCategoriesManager(ICourseCategoriesDal coursecategoriesDal, IMapper mapper)
        {
            _coursecategoriesDal = coursecategoriesDal;
            _mapper = mapper;
        }

         
         
        public List<CourseCategories> GetAll()
        {
            var model = _mapper.Map<List<CourseCategories>>(_coursecategoriesDal.GetList());
            return model;
        }

         
         
        public CourseCategories GetById(int id)
        {
            var model = _coursecategoriesDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public CourseCategories Add(CourseCategories coursecategories)
        {
            return _coursecategoriesDal.Add(coursecategories);
        }

         
         
        public CourseCategories Update(CourseCategories coursecategories)
        {
            return _coursecategoriesDal.Update(coursecategories);
        }

         
         
        public void Delete(CourseCategories coursecategories)
        {
            _coursecategoriesDal.Delete(coursecategories);
        }

         
         
        ///Courses Tablosu ile olan Foreign Key Column CourseId
        public List<CourseCategories> GetListByCoursesID(int courseid)
        {
            var model = _coursecategoriesDal.GetList(p => p.CourseId == courseid);
            return model;
        }

         
         
        ///Categories Tablosu ile olan Foreign Key Column FlagId
        public List<CourseCategories> GetListByCategoriesID(int flagid)
        {
            var model = _coursecategoriesDal.GetList(p => p.FlagId == flagid);
            return model;
        }
    }
}