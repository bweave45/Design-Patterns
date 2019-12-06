using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern.src.OnlineShops
{
    public abstract class OnlineShop
    {
        private double _priceOfItem;
        private double _priceOfItemOnSale;
        private List<IOnlineShopper> _shoppers = new List<IOnlineShopper>();

        public OnlineShop(double price, double salePrice)
        {
            _priceOfItem = price;
            _priceOfItemOnSale = salePrice;
        }

        public void Attach(IOnlineShopper investor)
        {
            _shoppers.Add(investor);
        }

        public void Detach(IOnlineShopper investor)
        {
            _shoppers.Remove(investor);
        }

        public void Notify()
        {
            foreach (IOnlineShopper shopper in _shoppers)
            {
                shopper.Update(this);
            }
            Console.WriteLine("");
        }

        public double Price
        {
            get { return _priceOfItem; }
        }

        public double SalePrice
        {
            get { return _priceOfItemOnSale; }

            set{
                if (value <= _priceOfItem)
                {
                    _priceOfItemOnSale = value;
                    Notify();
                }
            }
        }
    }
}
