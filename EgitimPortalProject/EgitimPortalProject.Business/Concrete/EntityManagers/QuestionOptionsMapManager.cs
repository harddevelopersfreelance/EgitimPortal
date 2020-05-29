using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionOptionsMapManager : IQuestionOptionsMapService
    {
        private IQuestionOptionsMapDal _questionoptionsmapDal;
        private readonly IMapper _mapper;

        public QuestionOptionsMapManager(IQuestionOptionsMapDal questionoptionsmapDal, IMapper mapper)
        {
            _questionoptionsmapDal = questionoptionsmapDal;
            _mapper = mapper;
        }

         
         
        public List<QuestionOptionsMap> GetAll()
        {
            var model = _mapper.Map<List<QuestionOptionsMap>>(_questionoptionsmapDal.GetList());
            return model;
        }

         
         
        public QuestionOptionsMap GetById(int id)
        {
            var model = _questionoptionsmapDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public QuestionOptionsMap Add(QuestionOptionsMap questionoptionsmap)
        {
            return _questionoptionsmapDal.Add(questionoptionsmap);
        }

         
         
        public QuestionOptionsMap Update(QuestionOptionsMap questionoptionsmap)
        {
            return _questionoptionsmapDal.Update(questionoptionsmap);
        }

         
         
        public void Delete(QuestionOptionsMap questionoptionsmap)
        {
            _questionoptionsmapDal.Delete(questionoptionsmap);
        }

         
         
        /// Tablosu ile olan Foreign Key Column QuestionId
        public List<QuestionOptionsMap> GetListByQuestionID(int questionid)
        {
            var model = _questionoptionsmapDal.GetList(p => p.QuestionId == questionid);
            return model;
        }

         
         
        /// Tablosu ile olan Foreign Key Column OptionId
        public List<QuestionOptionsMap> GetListByOptionID(int optionid)
        {
            var model = _questionoptionsmapDal.GetList(p => p.OptionId == optionid);
            return model;
        }

        
    }
}