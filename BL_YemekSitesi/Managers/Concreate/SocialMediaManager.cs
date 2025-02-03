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
    public class SocialMediaManager : ISocialMediaManager
    {
        private readonly ISocialMediaRepository _repository;

        public SocialMediaManager(ISocialMediaRepository repository)
        {
            _repository = repository;
        }

        public List<SocialMedia> TGetListAll()
        {
            return _repository.GetListAll();
        }
        public SocialMedia TGetByID(int id)
        {
            return _repository.GetByID(id);
        }
        public void TAdd(SocialMedia entity)
        {
            _repository.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _repository.Delete(entity);
        }

        

       

        public void TUpdate(SocialMedia entity)
        {
            _repository.Update(entity);
        }
    }
}
