using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using BL_YemekSitesi.Managers.GenericManager.Abstract;
using DAL_YemekSitesi.Context;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.Concreate
{
    public class MoneyCaseManager : IMoneyCaseManager
    {
        private readonly IMoneyCaseRepository _moneyCaseRepository;

        public MoneyCaseManager(IMoneyCaseRepository moneyCaseRepository)
        {
            _moneyCaseRepository = moneyCaseRepository;
        }

        public void TAdd(MoneyCase entity)
        {
            _moneyCaseRepository.Add(entity);
        }

        public void TDelete(MoneyCase entity)
        {
            _moneyCaseRepository.Delete(entity);    
        }

        public MoneyCase TGetByID(int id)
        {
            return _moneyCaseRepository.GetByID(id);
        }

        public List<MoneyCase> TGetListAll()
        {
            return _moneyCaseRepository.GetListAll();
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _moneyCaseRepository.TotalMoneyCaseAmount();
        }

        public void TUpdate(MoneyCase entity)
        {
            _moneyCaseRepository.Update(entity);
        }
    }
}
