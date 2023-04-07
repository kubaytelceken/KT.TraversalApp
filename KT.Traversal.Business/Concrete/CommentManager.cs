using KT.Traversal.Business.Abstract;
using KT.Traversal.DataAccessLayer.Abstract;
using KT.Traversal.DataAccessLayer.EntityFramework;
using KT.Traversal.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KT.Traversal.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentRepository _repository;
        public CommentManager(ICommentRepository repository)
        {
            this._repository = repository;
        }

        public List<Comment> GetListByFilter(Expression<Func<Comment, bool>> filter)
        {
            return _repository.GetListByFilter(filter);
        }

        public void TAdd(Comment entity)
        {
            _repository.Insert(entity);
        }

        public void TDelete(Comment entity)
        {
            _repository.Delete(entity);
        }

        public Comment TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _repository.GetList();
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _repository.GetListByFilter(x=> x.DestinationId == id);
        }

        public void TUpdate(Comment entity)
        {
            _repository.Update(entity);
        }
    }
}
