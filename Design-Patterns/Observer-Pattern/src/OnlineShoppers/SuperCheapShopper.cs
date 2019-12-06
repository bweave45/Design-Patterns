using System;
using System.Collections.Generic;
using System.Text;
using Observer_Pattern.src.OnlineShops;

namespace Observer_Pattern.src.OnlineShoppers
{
    public class SuperCheapShopper : IOnlineShopper
    {
        public double desiredSavings { get;} = .5;


        public void Update(OnlineShop shop)
        {
            if (1 - (shop.SalePrice / shop.Price) >= desiredSavings)
            {
                Console.WriteLine("The Super Cheap Shopper Bought The Item!");
            }
        }
    }
}
