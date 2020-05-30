using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ICauntriesService
    {
        List<Cauntries> GetAll();

        Cauntries GetById(int id);

        Cauntries Add(Cauntries cauntries);

        Cauntries Update(Cauntries cauntries);

        void Delete(Cauntries cauntries);
    }
}