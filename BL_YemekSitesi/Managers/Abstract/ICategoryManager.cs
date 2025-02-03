using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.GenericManager.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.Abstract
{
    public interface ICategoryManager : IGenericManager<Category>
    {
        public int TCategoryCount();
        public int TActiveCategoryCount();
        public int TPassiveCategoryCount();
    }
}
