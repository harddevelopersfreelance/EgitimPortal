using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionsService
    {
        List<Questions> GetAll();

        Questions GetById(int id);

        Questions Add(Questions questions);

        Questions Update(Questions questions);

        void Delete(Questions questions);

        List<Questions> GetListByCatgoryId(int categoryid);

        List<Questions> GetListByQuestionLevelId(int questionlevelid);

        List<Questions> GetListByQuestionTypeId(int questiontypeid);
    }
}