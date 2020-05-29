using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ICitiesService
    {
        List<Cities> GetAll();

        Cities GetById(int id);

        Cities Add(Cities cities);

        Cities Update(Cities cities);

        void Delete(Cities cities);

        List<Cities> GetListByCauntryID(int cauntryid);
    }
}