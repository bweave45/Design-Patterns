using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.src.Strategies
{
    public abstract class SortingStrategy
    {
        public abstract void Sort(List<int> list);
        protected void OutputList(List<int> list)
        {
            foreach (var num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
