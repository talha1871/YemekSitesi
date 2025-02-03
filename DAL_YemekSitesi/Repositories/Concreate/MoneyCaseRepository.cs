using Base_Model.Model.Entities;
using DAL_YemekSitesi.Context;
using DAL_YemekSitesi.GenericRepositories.Abstract;
using DAL_YemekSitesi.GenericRepositories.Concreate;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Repositories.Concreate
{
    public class MoneyCaseRepository : GenericRepository<MoneyCase>, IMoneyCaseRepository
    {
        public MoneyCaseRepository(SignalRContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using (var cnt =new SignalRContext())
            {
                return cnt.MoneyCases.Select(x=>x.TotalAmount).FirstOrDefault();
            }
        }
    }
}
