using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class AnnouncementUsersManager : IAnnouncementUsersService
    {
        private IAnnouncementUsersDal _announcementusersDal;
        private readonly IMapper _mapper;

        public AnnouncementUsersManager(IAnnouncementUsersDal announcementusersDal, IMapper mapper)
        {
            _announcementusersDal = announcementusersDal;
            _mapper = mapper;
        }

        public List<AnnouncementUsers> GetAll()
        {
            var model = _mapper.Map<List<AnnouncementUsers>>(_announcementusersDal.GetList());
            return model;
        }

        public AnnouncementUsers GetById(int id)
        {
            var model = _announcementusersDal.Get(p => p.Id == id);
            return model;
        }

        public AnnouncementUsers Add(AnnouncementUsers announcementusers)
        {
            return _announcementusersDal.Add(announcementusers);
        }

        public AnnouncementUsers Update(AnnouncementUsers announcementusers)
        {
            return _announcementusersDal.Update(announcementusers);
        }

        public void Delete(AnnouncementUsers announcementusers)
        {
            _announcementusersDal.Delete(announcementusers);
        }

        /// Tablosu ile olan Foreign Key Column AnnouncementId
        public List<AnnouncementUsers> GetListByAnnouncementId(int announcementid)
        {
            var model = _announcementusersDal.GetList(p => p.AnnouncementId == announcementid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column UserId
        public List<AnnouncementUsers> GetListByUserId(int userid)
        {
            var model = _announcementusersDal.GetList(p => p.UserId == userid);
            return model;
        }
    }
}