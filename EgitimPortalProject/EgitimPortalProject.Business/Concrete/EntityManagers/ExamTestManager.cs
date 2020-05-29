using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class ExamTestManager : IExamTestService
    {
        private IExamTestDal _examtestDal;
        private readonly IMapper _mapper;

        public ExamTestManager(IExamTestDal examtestDal, IMapper mapper)
        {
            _examtestDal = examtestDal;
            _mapper = mapper;
        }

         
         
        public List<ExamTest> GetAll()
        {
            var model = _mapper.Map<List<ExamTest>>(_examtestDal.GetList());
            return model;
        }

         
         
        public ExamTest GetById(int id)
        {
            var model = _examtestDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public ExamTest Add(ExamTest examtest)
        {
            return _examtestDal.Add(examtest);
        }

         
         
        public ExamTest Update(ExamTest examtest)
        {
            return _examtestDal.Update(examtest);
        }

         
         
        public void Delete(ExamTest examtest)
        {
            _examtestDal.Delete(examtest);
        }
    }
}