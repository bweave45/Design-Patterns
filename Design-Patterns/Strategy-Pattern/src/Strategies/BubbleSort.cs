using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Strategy_Pattern.src.Strategies
{
    public class BubbleSort : SortingStrategy
    {
        public override void Sort(List<int> list)
        {
            var localList = new List<int>(list);

            Console.WriteLine("-------Bubble Sort-------");
            OutputList(localList);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int temp;

            for (int i = 0; i <= localList.Count - 2; i++)
            {
                for (int j = 0; j <= localList.Count - 2; j++)
                {
                    if (localList[j] > localList[j + 1])
                    {
                        temp = localList[j + 1];
                        localList[j + 1] = localList[j];
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
