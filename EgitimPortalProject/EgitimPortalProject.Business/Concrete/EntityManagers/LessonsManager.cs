using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class LessonsManager : ILessonsService
    {
        private ILessonsDal _lessonsDal;
        private readonly IMapper _mapper;

        public LessonsManager(ILessonsDal lessonsDal, IMapper mapper)
        {
            _lessonsDal = lessonsDal;
            _mapper = mapper;
        }

        public List<Lessons> GetAll()
        {
            var model = _mapper.Map<List<Lessons>>(_lessonsDal.GetList());
            return model;
        }

        public Lessons GetById(int id)
        {
            var model = _lessonsDal.Get(p => p.Id == id);
            return model;
        }

        public Lessons Add(Lessons lessons)
        {
            return _lessonsDal.Add(lessons);
        }

        public Lessons Update(Lessons lessons)
        {
            return _lessonsDal.Update(lessons);
        }

        public void Delete(Lessons lessons)
        {
            _lessonsDal.Delete(lessons);
        }
    }
}