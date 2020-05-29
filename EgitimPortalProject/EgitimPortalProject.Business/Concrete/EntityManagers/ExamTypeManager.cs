using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class ExamTypeManager : IExamTypeService
    {
        private IExamTypeDal _examtypeDal;
        private readonly IMapper _mapper;

        public ExamTypeManager(IExamTypeDal examtypeDal, IMapper mapper)
        {
            _examtypeDal = examtypeDal;
            _mapper = mapper;
        }

         
         
        public List<ExamType> GetAll()
        {
            var model = _mapper.Map<List<ExamType>>(_examtypeDal.GetList());
            return model;
        }

         
         
        public ExamType GetById(int id)
        {
            var model = _examtypeDal.Get(p => p.TypeId == id);
            return model;
        }

         
         
        public ExamType Add(ExamType examtype)
        {
            return _examtypeDal.Add(examtype);
        }

         
         
        public ExamType Update(ExamType examtype)
        {
            return _examtypeDal.Update(examtype);
        }

         
         
        public void Delete(ExamType examtype)
        {
            _examtypeDal.Delete(examtype);
        }
    }
}