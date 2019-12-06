using Observer_Pattern.src.OnlineShops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern.src
{
    public interface IOnlineShopper
    {
        double desiredSavings { get; }
        void Update(OnlineShop shop);
    }
}
