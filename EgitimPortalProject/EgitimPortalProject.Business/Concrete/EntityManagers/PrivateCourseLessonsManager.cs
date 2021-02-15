using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class PrivateCourseLessonsManager : IPrivateCourseLessonsService
    {
        private IPrivateCourseLessonsDal _privatecourselessonsDal;
        private readonly IMapper _mapper;

        public PrivateCourseLessonsManager(IPrivateCourseLessonsDal privatecourselessonsDal, IMapper mapper)
        {
            _privatecourselessonsDal = privatecourselessonsDal;
            _mapper = mapper;
        }

        public List<PrivateCourseLessons> GetAll()
        {
            var model = _mapper.Map<List<PrivateCourseLessons>>(_privatecourselessonsDal.GetList());
            return model;
        }

        public PrivateCourseLessons GetById(int id)
        {
            var model = _privatecourselessonsDal.Get(p => p.Id == id);
            return model;
        }

        public PrivateCourseLessons Add(PrivateCourseLessons privatecourselessons)
        {
            return _privatecourselessonsDal.Add(privatecourselessons);
        }

        public PrivateCourseLessons Update(PrivateCourseLessons privatecourselessons)
        {
            return _privatecourselessonsDal.Update(privatecourselessons);
        }

        public void Delete(PrivateCourseLessons privatecourselessons)
        {
            _privatecourselessonsDal.Delete(privatecourselessons);
        }
    }
}