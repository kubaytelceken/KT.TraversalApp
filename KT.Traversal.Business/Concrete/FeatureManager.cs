using KT.Traversal.Business.Abstract;
using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureRepository featureRepository;

        public FeatureManager(IFeatureRepository featureRepository)
        {
            this.featureRepository = featureRepository;
        }

        public void TAdd(Feature entity)
        {
            featureRepository.Insert(entity);
        }

        public void TDelete(Feature entity)
        {
            featureRepository.Delete(entity);
        }

        public Feature TGetById(int id)
        {
            return featureRepository.GetById(id);
        }

        public List<Feature> TGetList()
        {
          return featureRepository.GetList();
        }

        public void TUpdate(Feature entity)
        {
            featureRepository.Update(entity);
        }
    }
}
