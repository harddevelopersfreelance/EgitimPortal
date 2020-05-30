using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IStudentCoursesService
    {
        List<StudentCourses> GetAll();

        StudentCourses GetById(int id);

        StudentCourses Add(StudentCourses studentcourses);

        StudentCourses Update(StudentCourses studentcourses);

        void Delete(StudentCourses studentcourses);

        List<StudentCourses> GetListByStudentsId(int studentid);

        List<StudentCourses> GetListByCoursesId(int courseid);
    }
}