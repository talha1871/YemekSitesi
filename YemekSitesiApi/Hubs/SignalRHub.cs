using BL_YemekSitesi.Managers.Abstract;
using DAL_YemekSitesi.Context;
using Microsoft.AspNetCore.SignalR;

namespace YemekSitesiApi.Hubs
{
    // Burası bir sunucu görevi görecek.
    // Dağıtım işlemini Hub sınıfı hangisiye o Hub sınıfı üzerinden dağıtacağız.
    public class SignalRHub: Hub
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IProductManager _productManager;
        private readonly IMoneyCaseManager _moneyCaseManager;
        private readonly IOrderManager _orderManager;

        

        public SignalRHub(ICategoryManager categoryManager, IProductManager productManager, IMoneyCaseManager moneyCaseManager, IOrderManager orderManager)
        {
            _categoryManager = categoryManager;
            _productManager = productManager;
            _moneyCaseManager = moneyCaseManager;
            _orderManager = orderManager;
        }

        public async Task SendStatistics()
        {
            var categorycount = _categoryManager.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", categorycount);

            var productcount = _productManager.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", productcount);

            var activecategorycount = _categoryManager.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", activecategorycount);

            var passivecategorycount = _categoryManager.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", passivecategorycount);

            var productcountbycategorynameashamburger = _productManager.TProductCountByCategoryNameAsHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameAsHamburger", productcountbycategorynameashamburger);
        
            var productcountbycategorynameasdrink = _productManager.TProductCountByCategoryNameAsDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameAsDrink", productcountbycategorynameasdrink);

            var productavgprice = _productManager.TProductAvgPrice();
            await Clients.All.SendAsync("ReceiveProductAvgPrice", productavgprice);

            var productnamebymaxprice = _productManager.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", productnamebymaxprice);


            var productnamebyminprice = _productManager.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", productnamebyminprice);

            var productavgpriceforhamburger = _productManager.TProductAvgPriceForHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceForHamburger", productavgpriceforhamburger + "₺");

            
        }
    
        public async Task SendProgressBar()
        {
            var totalmoneycaseamount = _moneyCaseManager.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalmoneycaseamount + "₺");

            var activeordercount = _orderManager.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeordercount);
        }
    }
}
