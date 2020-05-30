using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class LanguageTextManager : ILanguageTextService
    {
        private ILanguageTextDal _languagetextDal;
        private readonly IMapper _mapper;

        public LanguageTextManager(ILanguageTextDal languagetextDal, IMapper mapper)
        {
            _languagetextDal = languagetextDal;
            _mapper = mapper;
        }

        public List<LanguageText> GetAll()
        {
            var model = _mapper.Map<List<LanguageText>>(_languagetextDal.GetList());
            return model;
        }

        public LanguageText GetById(int id)
        {
            var model = _languagetextDal.Get(p => p.Id == id);
            return model;
        }

        public LanguageText Add(LanguageText languagetext)
        {
            return _languagetextDal.Add(languagetext);
        }

        public LanguageText Update(LanguageText languagetext)
        {
            return _languagetextDal.Update(languagetext);
        }

        public void Delete(LanguageText languagetext)
        {
            _languagetextDal.Delete(languagetext);
        }
    }
}