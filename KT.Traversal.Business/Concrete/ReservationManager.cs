﻿using KT.Traversal.Business.Abstract;
using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationRepository _repository;

        public ReservationManager(IReservationRepository repository)
        {
            _repository = repository;
        }

       

        public List<Reservation> GetListByFilter(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByApprove(int id)
        {
            return _repository.GetListWithReservationByApprove(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _repository.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _repository.GetListWithReservationByWaitApproval(id);
        }

        public void TAdd(Reservation entity)
        {
            _repository.Insert(entity); 
        }

        public void TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
