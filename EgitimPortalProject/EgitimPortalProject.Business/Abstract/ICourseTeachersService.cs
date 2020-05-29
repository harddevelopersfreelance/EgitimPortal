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

        List<CourseTeachers> GetListByTeachersID(int teacherid);

        List<CourseTeachers> GetListByCoursesID(int courseid);
    }
}