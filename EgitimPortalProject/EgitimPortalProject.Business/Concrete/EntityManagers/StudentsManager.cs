using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class StudentsManager : IStudentsService
    {
        private IStudentsDal _studentsDal;
        private readonly IMapper _mapper;

        public StudentsManager(IStudentsDal studentsDal, IMapper mapper)
        {
            _studentsDal = studentsDal;
            _mapper = mapper;
        }

         
         
        public List<Students> GetAll()
        {
            var model = _mapper.Map<List<Students>>(_studentsDal.GetList());
            return model;
        }

         
         
        public Students GetById(int id)
        {
            var model = _studentsDal.Get(p => p.StudentId == id);
            return model;
        }

         
         
        public Students Add(Students students)
        {
            return _studentsDal.Add(students);
        }

         
         
        public Students Update(Students students)
        {
            return _studentsDal.Update(students);
        }

         
         
        public void Delete(Students students)
        {
            _studentsDal.Delete(students);
        }
    }
}