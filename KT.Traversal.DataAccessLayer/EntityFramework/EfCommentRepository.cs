using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.DataAccessLayer.Concrete;
using KT.Traversal.DataAccessLayer.Repository;
using KT.Traversal.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x=>x.Destination).ToList();
            }
        }
    }
}
