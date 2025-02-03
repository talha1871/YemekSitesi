using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.Concreate
{
    public class TestimonialManager : ITestimonialManager
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public List<Testimonial> TGetListAll()
        {
           return _testimonialRepository.GetListAll();
        }
        public Testimonial TGetByID(int id)
        {
            return _testimonialRepository.GetByID(id);
        }
        public void TAdd(Testimonial entity)
        {
           _testimonialRepository.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialRepository.Delete(entity);
        }

  
        public void TUpdate(Testimonial entity)
        {_testimonialRepository.Update(entity);
        }
    }
}
