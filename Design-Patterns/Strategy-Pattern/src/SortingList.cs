using Strategy_Pattern.src.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.src
{
    public class SortingList
    {
        private List<int> _list = new List<int>();
        private SortingStrategy _strategy;

        public SortingList(List<int> list, SortingStrategy strategy)
        {
            _list = list;
            _strategy = strategy;
        }

        public void SetList(List<int> list)
        {
            _list = list;
        }

        public void SetSortingStrategy(SortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Sort()
        {
            _strategy.Sort(_list);
        }
    }
}
