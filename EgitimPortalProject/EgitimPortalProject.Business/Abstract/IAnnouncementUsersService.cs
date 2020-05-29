using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IAnnouncementUsersService
    {
        List<AnnouncementUsers> GetAll();

        AnnouncementUsers GetById(int id);

        AnnouncementUsers Add(AnnouncementUsers announcementusers);

        AnnouncementUsers Update(AnnouncementUsers announcementusers);

        void Delete(AnnouncementUsers announcementusers);

        List<AnnouncementUsers> GetListByAnnouncementID(int announcementid);

        List<AnnouncementUsers> GetListByUserID(int userid);
    }
}