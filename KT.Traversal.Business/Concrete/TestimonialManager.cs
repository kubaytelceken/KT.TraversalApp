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
    public class TestimonialManager : ITestimonialService
    {
        public ITestimonialRepository testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }

        public List<Testimonial> GetListByFilter(Expression<Func<Testimonial, bool>> filter)
        {
            return testimonialRepository.GetListByFilter(filter);
        }

        public void TAdd(Testimonial entity)
        {
            testimonialRepository.Insert(entity);
        }

        public void TDelete(Testimonial entity)
        {
            testimonialRepository.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
            return testimonialRepository.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return testimonialRepository.GetList();
        }

        public void TUpdate(Testimonial entity)
        {
            testimonialRepository.Update(entity);
        }
    }
}
