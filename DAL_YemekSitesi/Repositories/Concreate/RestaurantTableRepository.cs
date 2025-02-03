using Base_Model.Model.Entities;
using DAL_YemekSitesi.Context;
using DAL_YemekSitesi.GenericRepositories.Concreate;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Repositories.Concreate
{
    public class RestaurantTableRepository : GenericRepository<RestaurantTable>, IRestaurantTableRepository
    {
        public RestaurantTableRepository(SignalRContext context) : base(context)
        {
        }

        public int RestaurantTableCount()
        {
            using(var cnt = new SignalRContext())
            {
                return cnt.RestaurantTables.Count();
            }
        }
    }
}
