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
    public class DiscountManager : IDiscountManager
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountManager(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public void TAdd(Discount entity)
        {
            _discountRepository.Add(entity);
        }
        public List<Discount> TGetListAll()
        {
            return _discountRepository.GetListAll();
        }

        public Discount TGetByID(int id)
        {
            return _discountRepository.GetByID(id);
        }


        public void TUpdate(Discount entity)
        {
            _discountRepository.Update(entity); 
        }

        public void TDelete(Discount entity)
        {
            _discountRepository.Delete(entity);
        }
    }
}
