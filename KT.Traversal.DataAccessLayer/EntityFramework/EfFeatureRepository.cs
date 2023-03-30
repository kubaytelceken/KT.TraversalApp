using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.DataAccessLayer.Repository;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.DataAccessLayer.EntityFramework
{
    public  class EfFeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {

    }
}
