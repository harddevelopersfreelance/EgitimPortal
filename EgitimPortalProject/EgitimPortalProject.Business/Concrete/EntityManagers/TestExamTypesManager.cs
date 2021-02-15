using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class TestExamTypesManager : ITestExamTypesService
    {
        private ITestExamTypesDal _testexamtypesDal;
        private readonly IMapper _mapper;

        public TestExamTypesManager(ITestExamTypesDal testexamtypesDal, IMapper mapper)
        {
            _testexamtypesDal = testexamtypesDal;
            _mapper = mapper;
        }

        public List<TestExamTypes> GetAll()
        {
            var model = _mapper.Map<List<TestExamTypes>>(_testexamtypesDal.GetList());
            return model;
        }

        public TestExamTypes GetById(int id)
        {
            var model = _testexamtypesDal.Get(p => p.Id == id);
            return model;
        }

        public TestExamTypes Add(TestExamTypes testexamtypes)
        {
            return _testexamtypesDal.Add(testexamtypes);
        }

        public TestExamTypes Update(TestExamTypes testexamtypes)
        {
            return _testexamtypesDal.Update(testexamtypes);
        }

        public void Delete(TestExamTypes testexamtypes)
        {
            _testexamtypesDal.Delete(testexamtypes);
        }
    }
}