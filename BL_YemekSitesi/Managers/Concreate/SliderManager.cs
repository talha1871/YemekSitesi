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
    
    public class SliderManager : ISliderManager
    {
        private readonly ISliderRepository _sliderRepository;

        public SliderManager(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }

        public void TAdd(Slider entity)
        {
            _sliderRepository.Add(entity);
        }

        public void TDelete(Slider entity)
        {
            _sliderRepository.Delete(entity);
        }

        public Slider TGetByID(int id)
        {
            return _sliderRepository.GetByID(id);
        }

        public List<Slider> TGetListAll()
        {
            return _sliderRepository.GetListAll();
        }

        public void TUpdate(Slider entity)
        {
            throw new NotImplementedException();
        }
    }
}
