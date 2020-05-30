using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ICategoriesService
    {
        List<Categories> GetAll();

        Categories GetById(int id);

        Categories Add(Categories categories);

        Categories Update(Categories categories);

        void Delete(Categories categories);
    }
}