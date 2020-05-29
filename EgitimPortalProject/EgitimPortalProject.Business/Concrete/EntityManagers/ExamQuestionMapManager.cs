using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class ExamQuestionMapManager : IExamQuestionMapService
    {
        private IExamQuestionMapDal _examquestionmapDal;
        private readonly IMapper _mapper;

        public ExamQuestionMapManager(IExamQuestionMapDal examquestionmapDal, IMapper mapper)
        {
            _examquestionmapDal = examquestionmapDal;
            _mapper = mapper;
        }

         
         
        public List<ExamQuestionMap> GetAll()
        {
            var model = _mapper.Map<List<ExamQuestionMap>>(_examquestionmapDal.GetList());
            return model;
        }

         
         
        public ExamQuestionMap GetById(int id)
        {
            var model = _examquestionmapDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public ExamQuestionMap Add(ExamQuestionMap examquestionmap)
        {
            return _examquestionmapDal.Add(examquestionmap);
        }

         
         
        public ExamQuestionMap Update(ExamQuestionMap examquestionmap)
        {
            return _examquestionmapDal.Update(examquestionmap);
        }

         
         
        public void Delete(ExamQuestionMap examquestionmap)
        {
            _examquestionmapDal.Delete(examquestionmap);
        }

         
         
        /// Tablosu ile olan Foreign Key Column ExamId
        public List<ExamQuestionMap> GetListByExamID(int examid)
        {
            var model = _examquestionmapDal.GetList(p => p.ExamId == examid);
            return model;
        }

         
         
        /// Tablosu ile olan Foreign Key Column QuestionId
        public List<ExamQuestionMap> GetListByQuestionID(int questionid)
        {
            var model = _examquestionmapDal.GetList(p => p.QuestionId == questionid);
            return model;
        }

         
    }
}