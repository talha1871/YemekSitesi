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
    public class FeatureManager : IFeatureManager
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureManager(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public List<Feature> TGetListAll()
        {
            return _featureRepository.GetListAll();
        }
        public Feature TGetByID(int id)
        {
           return _featureRepository.GetByID(id);
        }

        public void TAdd(Feature entity)
        {
            _featureRepository.Add(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureRepository.Delete(entity); 
        }

       

        
        public void TUpdate(Feature entity)
        {
            _featureRepository.Update(entity);
        }
    }
}
