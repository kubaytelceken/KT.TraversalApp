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
    public class SubAboutManager : ISubAboutService
    {
        public ISubAboutRepository subAboutRepository;

        public SubAboutManager(ISubAboutRepository subAboutRepository)
        {
            this.subAboutRepository = subAboutRepository;
        }

        public List<SubAbout> GetListByFilter(Expression<Func<SubAbout, bool>> filter)
        {
            return subAboutRepository.GetListByFilter(filter);
        }

        public void TAdd(SubAbout entity)
        {
            subAboutRepository.Insert(entity);
        }

        public void TDelete(SubAbout entity)
        {
            subAboutRepository.Delete(entity);
        }

        public SubAbout TGetById(int id)
        {
            return subAboutRepository.GetById(id);
        }

        public List<SubAbout> TGetList()
        {
            return subAboutRepository.GetList();
        }

        public void TUpdate(SubAbout entity)
        {
            subAboutRepository.Update(entity);  
        }
    }
}
