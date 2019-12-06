using Observer_Pattern.src.OnlineShoppers;
using Observer_Pattern.src.OnlineShops;
using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var settingPrices = true;
            var googleStore = new GoogleStore(100,100);
            string menuInput = "";
            double saleInput;

            var genShopper = new GeneralShopper();
            var cheapShopper = new CheapShopper();
            var superCheapShopper = new SuperCheapShopper();

            googleStore.Attach(genShopper);
            googleStore.Attach(cheapShopper);
            googleStore.Attach(superCheapShopper);

            while (settingPrices)
            {
                Console.WriteLine("Whould you like to set a new sale price?");
                Console.WriteLine("Current Price: {0} \nCurrent SalePrice: {1}", googleStore.Price, googleStore.SalePrice);
                Console.WriteLine("Y or N?");
                menuInput = Console.ReadLine().ToUpper();

                switch (menuInput)
                {
                    case "Y":
                        Console.WriteLine("Enter Price: ");
                        try
                        {
                            saleInput = Convert.ToDouble(Console.ReadLine());
                            googleStore.SalePrice = saleInput;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Number Please!");
                        }
                        break;
                    case "N":
                        settingPrices = false;
                        break;
                    default:
                        Console.WriteLine("WHAT?");
                        break;
                }

            }
            Console.WriteLine("BYE!");
        }
    }
}
