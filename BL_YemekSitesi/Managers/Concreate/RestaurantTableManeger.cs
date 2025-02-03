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
    public class RestaurantTableManeger : IRestaurantTableManager
    {
        private readonly IRestaurantTableRepository _restaurantTableRepository;

        public RestaurantTableManeger(IRestaurantTableRepository restaurantTableRepository)
        {
            _restaurantTableRepository = restaurantTableRepository;
        }

        public void TAdd(RestaurantTable entity)
        {
            _restaurantTableRepository.Add(entity);
        }

        public void TDelete(RestaurantTable entity)
        {
            _restaurantTableRepository.Delete(entity);
        }

        public RestaurantTable TGetByID(int id)
        {
            return _restaurantTableRepository.GetByID(id);
        }

        public List<RestaurantTable> TGetListAll()
        {
            return _restaurantTableRepository.GetListAll();
        }

        public int TRestaurantTableCount()
        {
            return _restaurantTableRepository.RestaurantTableCount();
        }

        public void TUpdate(RestaurantTable entity)
        {
            _restaurantTableRepository.Update(entity);
        }
    }
}
