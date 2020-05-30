using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ITeacherCourseLessonsService
    {
        List<TeacherCourseLessons> GetAll();

        TeacherCourseLessons GetById(int id);

        TeacherCourseLessons Add(TeacherCourseLessons teachercourselessons);

        TeacherCourseLessons Update(TeacherCourseLessons teachercourselessons);

        void Delete(TeacherCourseLessons teachercourselessons);

        List<TeacherCourseLessons> GetListByCoursesId(int courseid);

        List<TeacherCourseLessons> GetListByLessonId(int lessonid);
    }
}