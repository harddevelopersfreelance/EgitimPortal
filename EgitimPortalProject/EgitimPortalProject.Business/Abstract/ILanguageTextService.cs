using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ILanguageTextService
    {
        List<LanguageText> GetAll();

        LanguageText GetById(int id);

        LanguageText Add(LanguageText languagetext);

        LanguageText Update(LanguageText languagetext);

        void Delete(LanguageText languagetext);
    }
}