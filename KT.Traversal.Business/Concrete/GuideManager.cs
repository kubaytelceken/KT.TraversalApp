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
    public class GuideManager : IGuideService
    {
        IGuideRepository _repository;

        public GuideManager(IGuideRepository repository)
        {
            _repository = repository;
        }

        public List<Guide> GetListByFilter(Expression<Func<Guide, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Guide entity)
        {
            _repository.Insert(entity);
        }

        public void TDelete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(Guide entity)
        {
            _repository.Update(entity);
        }
    }
}
