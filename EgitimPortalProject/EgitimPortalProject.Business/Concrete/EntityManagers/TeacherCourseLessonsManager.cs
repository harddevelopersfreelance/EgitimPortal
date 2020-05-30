using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class TeacherCourseLessonsManager : ITeacherCourseLessonsService
    {
        private ITeacherCourseLessonsDal _teachercourselessonsDal;
        private readonly IMapper _mapper;

        public TeacherCourseLessonsManager(ITeacherCourseLessonsDal teachercourselessonsDal, IMapper mapper)
        {
            _teachercourselessonsDal = teachercourselessonsDal;
            _mapper = mapper;
        }

        public List<TeacherCourseLessons> GetAll()
        {
            var model = _mapper.Map<List<TeacherCourseLessons>>(_teachercourselessonsDal.GetList());
            return model;
        }

        public TeacherCourseLessons GetById(int id)
        {
            var model = _teachercourselessonsDal.Get(p => p.Id == id);
            return model;
        }

        public TeacherCourseLessons Add(TeacherCourseLessons teachercourselessons)
        {
            return _teachercourselessonsDal.Add(teachercourselessons);
        }

        public TeacherCourseLessons Update(TeacherCourseLessons teachercourselessons)
        {
            return _teachercourselessonsDal.Update(teachercourselessons);
        }

        public void Delete(TeacherCourseLessons teachercourselessons)
        {
            _teachercourselessonsDal.Delete(teachercourselessons);
        }

        ///Courses Tablosu ile olan Foreign Key Column CourseId
        public List<TeacherCourseLessons> GetListByCoursesId(int courseid)
        {
            var model = _teachercourselessonsDal.GetList(p => p.CourseId == courseid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column LessonId
        public List<TeacherCourseLessons> GetListByLessonId(int lessonid)
        {
            var model = _teachercourselessonsDal.GetList(p => p.LessonId == lessonid);
            return model;
        }
    }
}