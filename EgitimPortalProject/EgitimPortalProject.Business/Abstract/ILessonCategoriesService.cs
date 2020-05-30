using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ILessonCategoriesService
    {
        List<LessonCategories> GetAll();

        LessonCategories GetById(int id);

        LessonCategories Add(LessonCategories lessoncategories);

        LessonCategories Update(LessonCategories lessoncategories);

        void Delete(LessonCategories lessoncategories);

        List<LessonCategories> GetListByLessonId(int lessonid);

        List<LessonCategories> GetListByCategoryId(int categoryid);
    }
}