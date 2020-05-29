using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SurveyQuestionOptionMapManager : ISurveyQuestionOptionMapService
    {
        private ISurveyQuestionOptionMapDal _surveyquestionoptionmapDal;
        private readonly IMapper _mapper;

        public SurveyQuestionOptionMapManager(ISurveyQuestionOptionMapDal surveyquestionoptionmapDal, IMapper mapper)
        {
            _surveyquestionoptionmapDal = surveyquestionoptionmapDal;
            _mapper = mapper;
        }

         
         
        public List<SurveyQuestionOptionMap> GetAll()
        {
            var model = _mapper.Map<List<SurveyQuestionOptionMap>>(_surveyquestionoptionmapDal.GetList());
            return model;
        }

         
         
        public SurveyQuestionOptionMap GetById(int id)
        {
            var model = _surveyquestionoptionmapDal.Get(p => p.id == id);
            return model;
        }

         
         
        public SurveyQuestionOptionMap Add(SurveyQuestionOptionMap surveyquestionoptionmap)
        {
            return _surveyquestionoptionmapDal.Add(surveyquestionoptionmap);
        }

         
         
        public SurveyQuestionOptionMap Update(SurveyQuestionOptionMap surveyquestionoptionmap)
        {
            return _surveyquestionoptionmapDal.Update(surveyquestionoptionmap);
        }

         
         
        public void Delete(SurveyQuestionOptionMap surveyquestionoptionmap)
        {
            _surveyquestionoptionmapDal.Delete(surveyquestionoptionmap);
        }

         
         
        /// Tablosu ile olan Foreign Key Column SurveyQuestionId
        public List<SurveyQuestionOptionMap> GetListBySurveyQuestionID(int surveyquestionid)
        {
            var model = _surveyquestionoptionmapDal.GetList(p => p.SurveyQuestionId == surveyquestionid);
            return model;
        }

         
         
        /// Tablosu ile olan Foreign Key Column SurveyOptionId
        public List<SurveyQuestionOptionMap> GetListBySurveyOptionID(int surveyoptionid)
        {
            var model = _surveyquestionoptionmapDal.GetList(p => p.SurveyOptionId == surveyoptionid);
            return model;
        }

        
    }
}