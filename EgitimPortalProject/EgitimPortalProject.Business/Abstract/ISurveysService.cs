using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISurveysService
    {
        List<Surveys> GetAll();

        Surveys GetById(int id);

        Surveys Add(Surveys surveys);

        Surveys Update(Surveys surveys);

        void Delete(Surveys surveys);

        List<Surveys> GetListByUserRolesID(int id);
    }
}