using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class CitiesManager : ICitiesService
    {
        private ICitiesDal _citiesDal;
        private readonly IMapper _mapper;

        public CitiesManager(ICitiesDal citiesDal, IMapper mapper)
        {
            _citiesDal = citiesDal;
            _mapper = mapper;
        }

         
         
        public List<Cities> GetAll()
        {
            var model = _mapper.Map<List<Cities>>(_citiesDal.GetList());
            return model;
        }

         
         
        public Cities GetById(int id)
        {
            var model = _citiesDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public Cities Add(Cities cities)
        {
            return _citiesDal.Add(cities);
        }

         
         
        public Cities Update(Cities cities)
        {
            return _citiesDal.Update(cities);
        }

         
         
        public void Delete(Cities cities)
        {
            _citiesDal.Delete(cities);
        }

         
         
        /// Tablosu ile olan Foreign Key Column CauntryId
        public List<Cities> GetListByCauntryID(int cauntryid)
        {
            var model = _citiesDal.GetList(p => p.CauntryId == cauntryid);
            return model;
        }
    }
}