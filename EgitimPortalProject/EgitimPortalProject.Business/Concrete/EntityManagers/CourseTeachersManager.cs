using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class CourseTeachersManager : ICourseTeachersService
    {
        private ICourseTeachersDal _courseteachersDal;
        private readonly IMapper _mapper;

        public CourseTeachersManager(ICourseTeachersDal courseteachersDal, IMapper mapper)
        {
            _courseteachersDal = courseteachersDal;
            _mapper = mapper;
        }

         
         
        public List<CourseTeachers> GetAll()
        {
            var model = _mapper.Map<List<CourseTeachers>>(_courseteachersDal.GetList());
            return model;
        }

         
         
        public CourseTeachers GetById(int id)
        {
            var model = _courseteachersDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public CourseTeachers Add(CourseTeachers courseteachers)
        {
            return _courseteachersDal.Add(courseteachers);
        }

         
         
        public CourseTeachers Update(CourseTeachers courseteachers)
        {
            return _courseteachersDal.Update(courseteachers);
        }

         
         
        public void Delete(CourseTeachers courseteachers)
        {
            _courseteachersDal.Delete(courseteachers);
        }

         
         
        ///Teachers Tablosu ile olan Foreign Key Column TeacherId
        public List<CourseTeachers> GetListByTeachersID(int teacherid)
        {
            var model = _courseteachersDal.GetList(p => p.TeacherId == teacherid);
            return model;
        }

         
         
        ///Courses Tablosu ile olan Foreign Key Column CourseId
        public List<CourseTeachers> GetListByCoursesID(int courseid)
        {
            var model = _courseteachersDal.GetList(p => p.CourseId == courseid);
            return model;
        }
    }
}