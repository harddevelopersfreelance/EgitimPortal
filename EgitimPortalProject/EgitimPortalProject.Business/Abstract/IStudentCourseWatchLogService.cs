using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IStudentCourseWatchLogService
    {
        List<StudentCourseWatchLog> GetAll();

        StudentCourseWatchLog GetById(int id);

        StudentCourseWatchLog Add(StudentCourseWatchLog studentcoursewatchlog);

        StudentCourseWatchLog Update(StudentCourseWatchLog studentcoursewatchlog);

        void Delete(StudentCourseWatchLog studentcoursewatchlog);
    }
}