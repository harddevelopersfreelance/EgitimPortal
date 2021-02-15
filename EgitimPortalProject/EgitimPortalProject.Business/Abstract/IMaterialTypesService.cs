using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IMaterialTypesService
    {
        List<MaterialTypes> GetAll();

        MaterialTypes GetById(int id);

        MaterialTypes Add(MaterialTypes materialtypes);

        MaterialTypes Update(MaterialTypes materialtypes);

        void Delete(MaterialTypes materialtypes);
    }
}