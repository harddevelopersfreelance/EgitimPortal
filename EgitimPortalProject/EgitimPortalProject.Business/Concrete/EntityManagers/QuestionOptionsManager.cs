using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionOptionsManager : IQuestionOptionsService
    {
        private IQuestionOptionsDal _questionoptionsDal;
        private readonly IMapper _mapper;

        public QuestionOptionsManager(IQuestionOptionsDal questionoptionsDal, IMapper mapper)
        {
            _questionoptionsDal = questionoptionsDal;
            _mapper = mapper;
        }

        public List<QuestionOptions> GetAll()
        {
            var model = _mapper.Map<List<QuestionOptions>>(_questionoptionsDal.GetList());
            return model;
        }

        public QuestionOptions GetById(int id)
        {
            var model = _questionoptionsDal.Get(p => p.Id == id);
            return model;
        }

        public QuestionOptions Add(QuestionOptions questionoptions)
        {
            return _questionoptionsDal.Add(questionoptions);
        }

        public QuestionOptions Update(QuestionOptions questionoptions)
        {
            return _questionoptionsDal.Update(questionoptions);
        }

        public void Delete(QuestionOptions questionoptions)
        {
            _questionoptionsDal.Delete(questionoptions);
        }

        /// Tablosu ile olan Foreign Key Column QuestionOptionTypeId
        public List<QuestionOptions> GetListByQuestionOptionTypeId(int questionoptiontypeid)
        {
            var model = _questionoptionsDal.GetList(p => p.QuestionOptionTypeId == questionoptiontypeid);
            return model;
        }
    }
}