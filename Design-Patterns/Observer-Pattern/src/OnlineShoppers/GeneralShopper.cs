using Observer_Pattern.src.OnlineShops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern.src.OnlineShoppers
{
    class GeneralShopper : IOnlineShopper
    {
        public double desiredSavings { get; } = .1;


        public void Update(OnlineShop shop)
        {
            if (1 - (shop.SalePrice / shop.Price) >= desiredSavings)
            {
                Console.WriteLine("The General Shopper Bought The Item!");
            }
        }
    }
}
