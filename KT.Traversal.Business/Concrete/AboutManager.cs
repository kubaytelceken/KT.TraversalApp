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
    public class AboutManager : IAboutService
    {
        IAboutRepository _repository;

        public AboutManager(IAboutRepository repository)
        {
            _repository = repository;       
        }

        public void TAdd(About entity)
        {
            _repository.Insert(entity);
        }

        public void TGetById(int id)
        {
            _repository.GetById(id);
        }

        public void TGetList()
        {
            _repository.GetList();
        }

        public void TDelete(About entity)
        {
           _repository.Delete(entity);
        }

        public void TUpdate(About entity)
        {
           _repository.Update(entity);
        }
    }
}
