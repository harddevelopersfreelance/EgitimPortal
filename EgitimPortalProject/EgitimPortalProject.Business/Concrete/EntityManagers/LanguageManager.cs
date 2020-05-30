using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class LanguageManager : ILanguageService
    {
        private ILanguageDal _languageDal;
        private readonly IMapper _mapper;

        public LanguageManager(ILanguageDal languageDal, IMapper mapper)
        {
            _languageDal = languageDal;
            _mapper = mapper;
        }

        public List<Language> GetAll()
        {
            var model = _mapper.Map<List<Language>>(_languageDal.GetList());
            return model;
        }

        public Language GetById(int id)
        {
            var model = _languageDal.Get(p => p.Id == id);
            return model;
        }

        public Language Add(Language language)
        {
            return _languageDal.Add(language);
        }

        public Language Update(Language language)
        {
            return _languageDal.Update(language);
        }

        public void Delete(Language language)
        {
            _languageDal.Delete(language);
        }
    }
}