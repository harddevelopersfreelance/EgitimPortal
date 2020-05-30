using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class CauntriesManager : ICauntriesService
    {
        private ICauntriesDal _cauntriesDal;
        private readonly IMapper _mapper;

        public CauntriesManager(ICauntriesDal cauntriesDal, IMapper mapper)
        {
            _cauntriesDal = cauntriesDal;
            _mapper = mapper;
        }

        public List<Cauntries> GetAll()
        {
            var model = _mapper.Map<List<Cauntries>>(_cauntriesDal.GetList());
            return model;
        }

        public Cauntries GetById(int id)
        {
            var model = _cauntriesDal.Get(p => p.Id == id);
            return model;
        }

        public Cauntries Add(Cauntries cauntries)
        {
            return _cauntriesDal.Add(cauntries);
        }

        public Cauntries Update(Cauntries cauntries)
        {
            return _cauntriesDal.Update(cauntries);
        }

        public void Delete(Cauntries cauntries)
        {
            _cauntriesDal.Delete(cauntries);
        }
    }
}