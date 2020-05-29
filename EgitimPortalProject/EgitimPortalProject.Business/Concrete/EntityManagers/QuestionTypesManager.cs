using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionTypesManager : IQuestionTypesService
    {
        private IQuestionTypesDal _questiontypesDal;
        private readonly IMapper _mapper;

        public QuestionTypesManager(IQuestionTypesDal questiontypesDal, IMapper mapper)
        {
            _questiontypesDal = questiontypesDal;
            _mapper = mapper;
        }

         
         
        public List<QuestionTypes> GetAll()
        {
            var model = _mapper.Map<List<QuestionTypes>>(_questiontypesDal.GetList());
            return model;
        }

         
         
        public QuestionTypes GetById(int id)
        {
            var model = _questiontypesDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public QuestionTypes Add(QuestionTypes questiontypes)
        {
            return _questiontypesDal.Add(questiontypes);
        }

         
         
        public QuestionTypes Update(QuestionTypes questiontypes)
        {
            return _questiontypesDal.Update(questiontypes);
        }

         
         
        public void Delete(QuestionTypes questiontypes)
        {
            _questiontypesDal.Delete(questiontypes);
        }
    }
}