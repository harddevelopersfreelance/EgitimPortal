using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionsManager : IQuestionsService
    {
        private IQuestionsDal _questionsDal;
        private readonly IMapper _mapper;

        public QuestionsManager(IQuestionsDal questionsDal, IMapper mapper)
        {
            _questionsDal = questionsDal;
            _mapper = mapper;
        }

        public List<Questions> GetAll()
        {
            var model = _mapper.Map<List<Questions>>(_questionsDal.GetList());
            return model;
        }

        public Questions GetById(int id)
        {
            var model = _questionsDal.Get(p => p.Id == id);
            return model;
        }

        public Questions Add(Questions questions)
        {
            return _questionsDal.Add(questions);
        }

        public Questions Update(Questions questions)
        {
            return _questionsDal.Update(questions);
        }

        public void Delete(Questions questions)
        {
            _questionsDal.Delete(questions);
        }

        /// Tablosu ile olan Foreign Key Column CategoryId
        public List<Questions> GetListByCatgoryID(int categoryid)
        {
            var model = _questionsDal.GetList(p => p.CategoryId == categoryid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column QuestionLevelId
        public List<Questions> GetListByQuestionLevelID(int questionlevelid)
        {
            var model = _questionsDal.GetList(p => p.QuestionLevelId == questionlevelid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column QuestionTypeId
        public List<Questions> GetListByQuestionTypeID(int questiontypeid)
        {
            var model = _questionsDal.GetList(p => p.QuestionTypeId == questiontypeid);
            return model;
        }

         
    }
}