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
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public List<Reservation> GetListWithReservationByApprove(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            throw new NotImplementedException();
            //using(var context = new Context())
            //{
            //    return context.Reservations.Include(x=>x.Destination(id)).ToList();
            //}
        }
    }
}
