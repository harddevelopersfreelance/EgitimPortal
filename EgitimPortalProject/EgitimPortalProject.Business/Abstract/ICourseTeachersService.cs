using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ICourseTeachersService
    {
        List<CourseTeachers> GetAll();

        CourseTeachers GetById(int id);

        CourseTeachers Add(CourseTeachers courseteachers);

        CourseTeachers Update(CourseTeachers courseteachers);

        void Delete(CourseTeachers courseteachers);

        List<CourseTeachers> GetListByTeachersId(int teacherid);

        List<CourseTeachers> GetListByCoursesId(int courseid);
    }
}