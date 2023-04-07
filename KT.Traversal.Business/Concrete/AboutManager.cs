using KT.Traversal.Business.Abstract;
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

        public About TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<About> TGetList()
        {
            return _repository.GetList();
        }

        public void TDelete(About entity)
        {
           _repository.Delete(entity);
        }

        public void TUpdate(About entity)
        {
           _repository.Update(entity);
        }

        public List<About> GetListByFilter(Expression<Func<About, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }
    }
}
