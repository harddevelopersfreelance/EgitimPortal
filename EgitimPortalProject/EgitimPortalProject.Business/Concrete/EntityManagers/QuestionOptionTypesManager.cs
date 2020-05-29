using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionOptionTypesManager : IQuestionOptionTypesService
    {
        private IQuestionOptionTypesDal _questionoptiontypesDal;
        private readonly IMapper _mapper;

        public QuestionOptionTypesManager(IQuestionOptionTypesDal questionoptiontypesDal, IMapper mapper)
        {
            _questionoptiontypesDal = questionoptiontypesDal;
            _mapper = mapper;
        }

         
         
        public List<QuestionOptionTypes> GetAll()
        {
            var model = _mapper.Map<List<QuestionOptionTypes>>(_questionoptiontypesDal.GetList());
            return model;
        }

         
         
        public QuestionOptionTypes GetById(int id)
        {
            var model = _questionoptiontypesDal.Get(p => p.id == id);
            return model;
        }

         
         
        public QuestionOptionTypes Add(QuestionOptionTypes questionoptiontypes)
        {
            return _questionoptiontypesDal.Add(questionoptiontypes);
        }

         
         
        public QuestionOptionTypes Update(QuestionOptionTypes questionoptiontypes)
        {
            return _questionoptiontypesDal.Update(questionoptiontypes);
        }

         
         
        public void Delete(QuestionOptionTypes questionoptiontypes)
        {
            _questionoptiontypesDal.Delete(questionoptiontypes);
        }
    }
}