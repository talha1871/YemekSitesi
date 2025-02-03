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
    public class AboutManager : IAboutManager
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }


        public List<About> TGetListAll()
        {
            return _aboutRepository.GetListAll();
        }
        public About TGetByID(int id)
        {
            return _aboutRepository.GetByID(id);
        }
        public void TAdd(About entity)
        {
            _aboutRepository.Add(entity);
        }
        public void TUpdate(About entity)
        {
            _aboutRepository.Update(entity);
        }
        public void TDelete(About entity)
        {
            _aboutRepository.Delete(entity);
        }

        

       

        
    }

}
