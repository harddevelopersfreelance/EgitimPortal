using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SurveysManager : ISurveysService
    {
        private ISurveysDal _surveysDal;
        private readonly IMapper _mapper;

        public SurveysManager(ISurveysDal surveysDal, IMapper mapper)
        {
            _surveysDal = surveysDal;
            _mapper = mapper;
        }

         
         
        public List<Surveys> GetAll()
        {
            var model = _mapper.Map<List<Surveys>>(_surveysDal.GetList());
            return model;
        }

         
         
        public Surveys GetById(int id)
        {
            var model = _surveysDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public Surveys Add(Surveys surveys)
        {
            return _surveysDal.Add(surveys);
        }

         
         
        public Surveys Update(Surveys surveys)
        {
            return _surveysDal.Update(surveys);
        }

         
         
        public void Delete(Surveys surveys)
        {
            _surveysDal.Delete(surveys);
        }

         
         
        ///UserRoles Tablosu ile olan Foreign Key Column Id
        public List<Surveys> GetListByUserRolesID(int id)
        {
            var model = _surveysDal.GetList(p => p.Id == id);
            return model;
        }
    }
}