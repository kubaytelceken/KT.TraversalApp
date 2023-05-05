using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.DataAccessLayer.Concrete;
using KT.Traversal.DataAccessLayer.Repository;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.DataAccessLayer.EntityFramework
{
    public class EfGuideRepository : GenericRepository<Guide>, IGuideRepository
    {
        Context context = new Context();
        public void ChangeToFalseGuide(int id)
        {
      
            var guide = context.Guides.Find(id);
            guide.Status = false;
            context.Update(guide);
            context.SaveChanges();

        }

        public void ChangeToTrueGuide(int id)
        {

            var guide = context.Guides.Find(id);
            guide.Status = true;
            context.Update(guide);
            context.SaveChanges();
        }
    }
}
