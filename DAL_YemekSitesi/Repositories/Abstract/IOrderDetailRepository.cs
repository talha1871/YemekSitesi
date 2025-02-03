using Base_Model.Model.Entities;
using DAL_YemekSitesi.GenericRepositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Repositories.Abstract
{
    public interface IOrderDetailRepository: IGenericRepository<OrderDetail>
    {
    }
}
