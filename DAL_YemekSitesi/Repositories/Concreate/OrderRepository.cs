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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SignalRContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using(var context = new SignalRContext())
            {
                return context.Orders.Where(x => x.OrderDescription == "Dolu").Count();
            }
        }

        public decimal LastTotalOrderFee()
        {
            using var cnt = new SignalRContext();
            return cnt.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(x => x.TotalOrderPrice).Sum();
        }

        

        public int TotalOrderCount()
        {
            using (var context = new SignalRContext())
            {
                return context.Orders.Count();
            }
        }
    }
}
