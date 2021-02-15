using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class GenderManager : IGenderService
    {
        private IGenderDal _genderDal;
        private readonly IMapper _mapper;

        public GenderManager(IGenderDal genderDal, IMapper mapper)
        {
            _genderDal = genderDal;
            _mapper = mapper;
        }

        public List<Gender> GetAll()
        {
            var model = _mapper.Map<List<Gender>>(_genderDal.GetList());
            return model;
        }

        public Gender GetById(int id)
        {
            var model = _genderDal.Get(p => p.Id == id);
            return model;
        }

        public Gender Add(Gender gender)
        {
            return _genderDal.Add(gender);
        }

        public Gender Update(Gender gender)
        {
            return _genderDal.Update(gender);
        }

        public void Delete(Gender gender)
        {
            _genderDal.Delete(gender);
        }
    }
}