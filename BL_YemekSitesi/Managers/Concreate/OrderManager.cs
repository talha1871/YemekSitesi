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
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public int TActiveOrderCount()
        {
            return _orderRepository.ActiveOrderCount();
        }

       

        public void TAdd(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void TDelete(Order entity)
        {
            _orderRepository.Delete(entity);
        }

        public Order TGetByID(int id)
        {
            return _orderRepository.GetByID(id);
        }

        public List<Order> TGetListAll()
        {
            return _orderRepository.GetListAll();
        }

        public int TTotalOrderCount()
        {
            return _orderRepository.TotalOrderCount();
        }

        public decimal TLastTotalOrderFee()
        {
            return _orderRepository.LastTotalOrderFee();
        }

        public void TUpdate(Order entity)
        {
            _orderRepository.Update(entity);
        }

       
    }
}
