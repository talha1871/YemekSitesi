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
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(SignalRContext context) : base(context)
        {
        }
    }
}
