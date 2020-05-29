using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SettingsManager : ISettingsService
    {
        private ISettingsDal _settingsDal;
        private readonly IMapper _mapper;

        public SettingsManager(ISettingsDal settingsDal, IMapper mapper)
        {
            _settingsDal = settingsDal;
            _mapper = mapper;
        }

         
         
        public List<Settings> GetAll()
        {
            var model = _mapper.Map<List<Settings>>(_settingsDal.GetList());
            return model;
        }

         
         
        public Settings GetById(int id)
        {
            var model = _settingsDal.Get(p => p.id == id);
            return model;
        }

         
         
        public Settings Add(Settings settings)
        {
            return _settingsDal.Add(settings);
        }

         
         
        public Settings Update(Settings settings)
        {
            return _settingsDal.Update(settings);
        }

         
         
        public void Delete(Settings settings)
        {
            _settingsDal.Delete(settings);
        }

         
         
        /// Tablosu ile olan Foreign Key Column UserId
        public List<Settings> GetListByUserID(int userid)
        {
            var model = _settingsDal.GetList(p => p.UserId == userid);
            return model;
        }

         
         
        /// Tablosu ile olan Foreign Key Column RoleId
        public List<Settings> GetListByRoleID(int roleid)
        {
            var model = _settingsDal.GetList(p => p.RoleId == roleid);
            return model;
        }
    }
}