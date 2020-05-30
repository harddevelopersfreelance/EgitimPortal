using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class CoursesManager : ICoursesService
    {
        private ICoursesDal _coursesDal;
        private readonly IMapper _mapper;

        public CoursesManager(ICoursesDal coursesDal, IMapper mapper)
        {
            _coursesDal = coursesDal;
            _mapper = mapper;
        }

        public List<Courses> GetAll()
        {
            var model = _mapper.Map<List<Courses>>(_coursesDal.GetList());
            return model;
        }

        public Courses GetById(int id)
        {
            var model = _coursesDal.Get(p => p.Id == id);
            return model;
        }

        public Courses Add(Courses courses)
        {
            return _coursesDal.Add(courses);
        }

        public Courses Update(Courses courses)
        {
            return _coursesDal.Update(courses);
        }

        public void Delete(Courses courses)
        {
            _coursesDal.Delete(courses);
        }
    }
}