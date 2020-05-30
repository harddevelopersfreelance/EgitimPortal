using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet("GetAll")]
        public List<Language> GetAll()
        {
            return _languageService.GetAll();
        }

        [HttpGet("GetById")]
        public Language GetById(int id)
        {
            return _languageService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] Language _languageFormData)
        {
            Language _language = new Language();

            _languageService.Add(_language);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] Language _languageFormData)
        {
            Language _language = new Language();

            _languageService.Update(_language);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _languageService.Delete(_languageService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}