using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class AnnouncementsManager : IAnnouncementsService
    {
        private IAnnouncementsDal _announcementsDal;
        private readonly IMapper _mapper;

        public AnnouncementsManager(IAnnouncementsDal announcementsDal, IMapper mapper)
        {
            _announcementsDal = announcementsDal;
            _mapper = mapper;
        }

        public List<Announcements> GetAll()
        {
            var model = _mapper.Map<List<Announcements>>(_announcementsDal.GetList());
            return model;
        }

        public Announcements GetById(int id)
        {
            var model = _announcementsDal.Get(p => p.Id == id);
            return model;
        }

        public Announcements Add(Announcements announcements)
        {
            return _announcementsDal.Add(announcements);
        }

        public Announcements Update(Announcements announcements)
        {
            return _announcementsDal.Update(announcements);
        }

        public void Delete(Announcements announcements)
        {
            _announcementsDal.Delete(announcements);
        }
    }
}