using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ILessonMaterialsService
    {
        List<LessonMaterials> GetAll();

        LessonMaterials GetById(int id);

        LessonMaterials Add(LessonMaterials lessonmaterials);

        LessonMaterials Update(LessonMaterials lessonmaterials);

        void Delete(LessonMaterials lessonmaterials);

        List<LessonMaterials> GetListByExamTypeID(int typeid);

        List<LessonMaterials> GetListByLessonID(int lessonid);
    }
}