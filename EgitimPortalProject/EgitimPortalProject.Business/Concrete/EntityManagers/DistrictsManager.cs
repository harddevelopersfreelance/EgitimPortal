using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class DistrictsManager : IDistrictsService
    {
        private IDistrictsDal _districtsDal;
        private readonly IMapper _mapper;

        public DistrictsManager(IDistrictsDal districtsDal, IMapper mapper)
        {
            _districtsDal = districtsDal;
            _mapper = mapper;
        }

         
         
        public List<Districts> GetAll()
        {
            var model = _mapper.Map<List<Districts>>(_districtsDal.GetList());
            return model;
        }

         
         
        public Districts GetById(int id)
        {
            var model = _districtsDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public Districts Add(Districts districts)
        {
            return _districtsDal.Add(districts);
        }

         
         
        public Districts Update(Districts districts)
        {
            return _districtsDal.Update(districts);
        }

         
         
        public void Delete(Districts districts)
        {
            _districtsDal.Delete(districts);
        }

         
         
        /// Tablosu ile olan Foreign Key Column CityId
        public List<Districts> GetListByCityID(int cityid)
        {
            var model = _districtsDal.GetList(p => p.CityId == cityid);
            return model;
        }

        
    }
}