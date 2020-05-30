using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class StudentCoursesManager : IStudentCoursesService
    {
        private IStudentCoursesDal _studentcoursesDal;
        private readonly IMapper _mapper;

        public StudentCoursesManager(IStudentCoursesDal studentcoursesDal, IMapper mapper)
        {
            _studentcoursesDal = studentcoursesDal;
            _mapper = mapper;
        }

        public List<StudentCourses> GetAll()
        {
            var model = _mapper.Map<List<StudentCourses>>(_studentcoursesDal.GetList());
            return model;
        }

        public StudentCourses GetById(int id)
        {
            var model = _studentcoursesDal.Get(p => p.Id == id);
            return model;
        }

        public StudentCourses Add(StudentCourses studentcourses)
        {
            return _studentcoursesDal.Add(studentcourses);
        }

        public StudentCourses Update(StudentCourses studentcourses)
        {
            return _studentcoursesDal.Update(studentcourses);
        }

        public void Delete(StudentCourses studentcourses)
        {
            _studentcoursesDal.Delete(studentcourses);
        }

        ///Students Tablosu ile olan Foreign Key Column StudentId
        public List<StudentCourses> GetListByStudentsId(int studentid)
        {
            var model = _studentcoursesDal.GetList(p => p.StudentId == studentid);
            return model;
        }

        ///Courses Tablosu ile olan Foreign Key Column CourseId
        public List<StudentCourses> GetListByCoursesId(int courseid)
        {
            var model = _studentcoursesDal.GetList(p => p.CourseId == courseid);
            return model;
        }
    }
}