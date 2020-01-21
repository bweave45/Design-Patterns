using Strategy_Pattern.src;
using Strategy_Pattern.src.Strategies;
using System;
using System.Collections.Generic;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> 
            { 12, 435, 123, 45, 1243, 6785, 12, 45, 2, 87, 457, 89, 358, 96, 682, 
              99, 55, 78, 435, 685, 124, 4, 1, 42353, 463143, 81, 18, 457, 23561,
              357626, 5, 4, 9009, 9889, 346563, 1111, 2234, 1234, 56643, 7, 7, 2, 5 
            };

            var sortList = new SortingList(list, new BubbleSort());
            sortList.Sort();

            sortList.SetSortingStrategy(new InsertionSort());
            sortList.Sort();
        }
    }
}
