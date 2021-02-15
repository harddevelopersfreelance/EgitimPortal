using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ILanguageService
    {
        List<Language> GetAll();

        Language GetById(int id);

        Language Add(Language language);

        Language Update(Language language);

        void Delete(Language language);
    }
}