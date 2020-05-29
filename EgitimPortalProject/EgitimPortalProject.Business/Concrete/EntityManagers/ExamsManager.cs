using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class ExamsManager : IExamsService
    {
        private IExamsDal _examsDal;
        private readonly IMapper _mapper;

        public ExamsManager(IExamsDal examsDal, IMapper mapper)
        {
            _examsDal = examsDal;
            _mapper = mapper;
        }

         
         
        public List<Exams> GetAll()
        {
            var model = _mapper.Map<List<Exams>>(_examsDal.GetList());
            return model;
        }

         
         
        public Exams GetById(int id)
        {
            var model = _examsDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public Exams Add(Exams exams)
        {
            return _examsDal.Add(exams);
        }

         
         
        public Exams Update(Exams exams)
        {
            return _examsDal.Update(exams);
        }

         
         
        public void Delete(Exams exams)
        {
            _examsDal.Delete(exams);
        }

         
         
        /// Tablosu ile olan Foreign Key Column ExamTypeId
        public List<Exams> GetListByExamTypeID(int examtypeid)
        {
            var model = _examsDal.GetList(p => p.ExamTypeId == examtypeid);
            return model;
        }

        
    }
}