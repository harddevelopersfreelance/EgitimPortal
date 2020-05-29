using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ICourseCategoriesService
    {
        List<CourseCategories> GetAll();

        CourseCategories GetById(int id);

        CourseCategories Add(CourseCategories coursecategories);

        CourseCategories Update(CourseCategories coursecategories);

        void Delete(CourseCategories coursecategories);

        List<CourseCategories> GetListByCoursesID(int courseid);

        List<CourseCategories> GetListByCategoriesID(int flagid);
    }
}