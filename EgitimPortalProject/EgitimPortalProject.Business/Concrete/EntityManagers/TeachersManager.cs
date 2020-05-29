using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class TeachersManager : ITeachersService
    {
        private ITeachersDal _teachersDal;
        private readonly IMapper _mapper;

        public TeachersManager(ITeachersDal teachersDal, IMapper mapper)
        {
            _teachersDal = teachersDal;
            _mapper = mapper;
        }

         
         
        public List<Teachers> GetAll()
        {
            var model = _mapper.Map<List<Teachers>>(_teachersDal.GetList());
            return model;
        }

         
         
        public Teachers GetById(int id)
        {
            var model = _teachersDal.Get(p => p.TeacherId == id);
            return model;
        }

         
         
        public Teachers Add(Teachers teachers)
        {
            return _teachersDal.Add(teachers);
        }

         
         
        public Teachers Update(Teachers teachers)
        {
            return _teachersDal.Update(teachers);
        }

         
         
        public void Delete(Teachers teachers)
        {
            _teachersDal.Delete(teachers);
        }
    }
}