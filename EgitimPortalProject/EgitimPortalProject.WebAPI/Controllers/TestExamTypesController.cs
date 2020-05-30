using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestExamTypesController : ControllerBase
    {
        private ITestExamTypesService _testexamtypesService;

        public TestExamTypesController(ITestExamTypesService testexamtypesService)
        {
            _testexamtypesService = testexamtypesService;
        }

        [HttpGet("GetAll")]
        public List<TestExamTypes> GetAll()
        {
            return _testexamtypesService.GetAll();
        }

        [HttpGet("GetById")]
        public TestExamTypes GetById(int id)
        {
            return _testexamtypesService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] TestExamTypes _testexamtypesFormData)
        {
            TestExamTypes _testexamtypes = new TestExamTypes();

            _testexamtypesService.Add(_testexamtypes);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] TestExamTypes _testexamtypesFormData)
        {
            TestExamTypes _testexamtypes = new TestExamTypes();

            _testexamtypesService.Update(_testexamtypes);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _testexamtypesService.Delete(_testexamtypesService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}