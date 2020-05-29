using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IDistrictsService
    {
        List<Districts> GetAll();

        Districts GetById(int id);

        Districts Add(Districts districts);

        Districts Update(Districts districts);

        void Delete(Districts districts);

        List<Districts> GetListByCityID(int cityid);
    }
}