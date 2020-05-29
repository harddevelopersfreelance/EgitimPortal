using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SurveyQuestionOptionsTypesManager : ISurveyQuestionOptionsTypesService
    {
        private ISurveyQuestionOptionsTypesDal _surveyquestionoptionstypesDal;
        private readonly IMapper _mapper;

        public SurveyQuestionOptionsTypesManager(ISurveyQuestionOptionsTypesDal surveyquestionoptionstypesDal, IMapper mapper)
        {
            _surveyquestionoptionstypesDal = surveyquestionoptionstypesDal;
            _mapper = mapper;
        }

         
         
        public List<SurveyQuestionOptionsTypes> GetAll()
        {
            var model = _mapper.Map<List<SurveyQuestionOptionsTypes>>(_surveyquestionoptionstypesDal.GetList());
            return model;
        }

         
         
        public SurveyQuestionOptionsTypes GetById(int id)
        {
            var model = _surveyquestionoptionstypesDal.Get(p => p.id == id);
            return model;
        }

         
         
        public SurveyQuestionOptionsTypes Add(SurveyQuestionOptionsTypes surveyquestionoptionstypes)
        {
            return _surveyquestionoptionstypesDal.Add(surveyquestionoptionstypes);
        }

         
         
        public SurveyQuestionOptionsTypes Update(SurveyQuestionOptionsTypes surveyquestionoptionstypes)
        {
            return _surveyquestionoptionstypesDal.Update(surveyquestionoptionstypes);
        }

         
         
        public void Delete(SurveyQuestionOptionsTypes surveyquestionoptionstypes)
        {
            _surveyquestionoptionstypesDal.Delete(surveyquestionoptionstypes);
        }
    }
}