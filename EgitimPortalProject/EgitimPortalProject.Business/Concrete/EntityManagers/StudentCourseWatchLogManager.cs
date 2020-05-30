using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class StudentCourseWatchLogManager : IStudentCourseWatchLogService
    {
        private IStudentCourseWatchLogDal _studentcoursewatchlogDal;
        private readonly IMapper _mapper;

        public StudentCourseWatchLogManager(IStudentCourseWatchLogDal studentcoursewatchlogDal, IMapper mapper)
        {
            _studentcoursewatchlogDal = studentcoursewatchlogDal;
            _mapper = mapper;
        }

        public List<StudentCourseWatchLog> GetAll()
        {
            var model = _mapper.Map<List<StudentCourseWatchLog>>(_studentcoursewatchlogDal.GetList());
            return model;
        }

        public StudentCourseWatchLog GetById(int id)
        {
            var model = _studentcoursewatchlogDal.Get(p => p.Id == id);
            return model;
        }

        public StudentCourseWatchLog Add(StudentCourseWatchLog studentcoursewatchlog)
        {
            return _studentcoursewatchlogDal.Add(studentcoursewatchlog);
        }

        public StudentCourseWatchLog Update(StudentCourseWatchLog studentcoursewatchlog)
        {
            return _studentcoursewatchlogDal.Update(studentcoursewatchlog);
        }

        public void Delete(StudentCourseWatchLog studentcoursewatchlog)
        {
            _studentcoursewatchlogDal.Delete(studentcoursewatchlog);
        }
    }
}