using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class LessonMaterialsManager : ILessonMaterialsService
    {
        private ILessonMaterialsDal _lessonmaterialsDal;
        private readonly IMapper _mapper;

        public LessonMaterialsManager(ILessonMaterialsDal lessonmaterialsDal, IMapper mapper)
        {
            _lessonmaterialsDal = lessonmaterialsDal;
            _mapper = mapper;
        }

        public List<LessonMaterials> GetAll()
        {
            var model = _mapper.Map<List<LessonMaterials>>(_lessonmaterialsDal.GetList());
            return model;
        }

        public LessonMaterials GetById(int id)
        {
            var model = _lessonmaterialsDal.Get(p => p.MaterialId == id);
            return model;
        }

        public LessonMaterials Add(LessonMaterials lessonmaterials)
        {
            return _lessonmaterialsDal.Add(lessonmaterials);
        }

        public LessonMaterials Update(LessonMaterials lessonmaterials)
        {
            return _lessonmaterialsDal.Update(lessonmaterials);
        }

        public void Delete(LessonMaterials lessonmaterials)
        {
            _lessonmaterialsDal.Delete(lessonmaterials);
        }

        ///ExamType Tablosu ile olan Foreign Key Column TypeId
        public List<LessonMaterials> GetListByExamTypeId(int typeid)
        {
            var model = _lessonmaterialsDal.GetList(p => p.TypeId == typeid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column LessonId
        public List<LessonMaterials> GetListByLessonId(int lessonid)
        {
            var model = _lessonmaterialsDal.GetList(p => p.LessonId == lessonid);
            return model;
        }
    }
}