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
    public class DestinationManager : IDestinationService
    {
        IDestinationRepository destinationRepository;

        public DestinationManager(IDestinationRepository destinationRepository)
        {
            this.destinationRepository = destinationRepository;
        }

        public void TAdd(Destination entity)
        {
            destinationRepository.Insert(entity);
        }

        public void TDelete(Destination entity)
        {
            destinationRepository.Delete(entity);
        }

        public Destination TGetById(int id)
        {
            return destinationRepository.GetById(id);
        }

        public List<Destination> TGetList()
        {
            return destinationRepository.GetList();
        }

        public void TUpdate(Destination entity)
        {
            destinationRepository.Update(entity);
        }
    }
}
