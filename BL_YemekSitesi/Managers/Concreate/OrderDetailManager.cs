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
    public class OrderDetailManager : IOrderDetailManager
    {   
       private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailManager(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public void TAdd(OrderDetail entity)
        {
            _orderDetailRepository.Add(entity);
        }

        public void TDelete(OrderDetail entity)
        {
            _orderDetailRepository.Delete(entity);
        }

        public OrderDetail TGetByID(int id)
        {
            return _orderDetailRepository.GetByID(id);
        }

        public List<OrderDetail> TGetListAll()
        {
            return _orderDetailRepository.GetListAll(); 
        }

        public void TUpdate(OrderDetail entity)
        {
            _orderDetailRepository.Update(entity);
        }
    }
}
