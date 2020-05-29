using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IAnnouncementsService
    {
        List<Announcements> GetAll();

        Announcements GetById(int id);

        Announcements Add(Announcements announcements);

        Announcements Update(Announcements announcements);

        void Delete(Announcements announcements);
    }
}