using Observer_Pattern.src.OnlineShops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern.src.OnlineShoppers
{
    public class CheapShopper : IOnlineShopper
    {
        public double desiredSavings { get; } = .25;


        public void Update(OnlineShop shop)
        {
            if (1 - (shop.SalePrice / shop.Price) >= desiredSavings)
            {
                Console.WriteLine("The Cheap Shopper Bought The Item!");
            }
        }
    }
}
