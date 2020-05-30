using EgitimPortal.Business.Abstract;
using EgitimPortal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EgitimPortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageTextController : ControllerBase
    {
        private ILanguageTextService _languagetextService;

        public LanguageTextController(ILanguageTextService languagetextService)
        {
            _languagetextService = languagetextService;
        }

        [HttpGet("GetAll")]
        public List<LanguageText> GetAll()
        {
            return _languagetextService.GetAll();
        }

        [HttpGet("GetById")]
        public LanguageText GetById(int id)
        {
            return _languagetextService.GetById(id);
        }

        [HttpPost("Insert")]
        public void Insert([FromBody] LanguageText _languagetextFormData)
        {
            LanguageText _languagetext = new LanguageText();

            _languagetextService.Add(_languagetext);
        }

        [HttpPut("Update")]
        public void Update(int id, [FromBody] LanguageText _languagetextFormData)
        {
            LanguageText _languagetext = new LanguageText();

            _languagetextService.Update(_languagetext);

            //Duruma gore yazılacak
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _languagetextService.Delete(_languagetextService.GetById(id));
            //Duruma gore yazılacak
        }
    }
}