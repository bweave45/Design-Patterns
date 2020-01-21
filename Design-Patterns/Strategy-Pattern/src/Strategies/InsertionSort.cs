using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Strategy_Pattern.src.Strategies
{
    class InsertionSort: SortingStrategy
    {
        public override void Sort(List<int> list)
        {
            var localList = new List<int>(list);

            Console.WriteLine("-------Insertion Sort-------");
            OutputList(localList);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int temp;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (localList[j - 1] > localList[j])
                    {
                        temp = localList[j - 1];
                        localList[j - 1] = localList[j];
                        localList[j] = temp;
                    }
                }
            }

            stopWatch.Stop();

            OutputList(localList);

            Console.WriteLine("Time Elapsed: {0} Milliseconds", stopWatch.Elapsed.TotalMilliseconds);

        }
    }
}
