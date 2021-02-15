using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ITestExamTypesService
    {
        List<TestExamTypes> GetAll();

        TestExamTypes GetById(int id);

        TestExamTypes Add(TestExamTypes testexamtypes);

        TestExamTypes Update(TestExamTypes testexamtypes);

        void Delete(TestExamTypes testexamtypes);
    }
}