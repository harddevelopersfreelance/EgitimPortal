using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISettingsService
    {
        List<Settings> GetAll();

        Settings GetById(int id);

        Settings Add(Settings settings);

        Settings Update(Settings settings);

        void Delete(Settings settings);

        List<Settings> GetListByUserId(int userid);

        List<Settings> GetListByRoleId(int roleid);
    }
}