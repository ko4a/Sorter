using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorter.Sort;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            var bubbleSorter = new BubbleSort<int>();
            var randomiser = new Random();
            var items = new List<int>();

            for (int i = 0; i < 10_000; i++)
            {
                items.Add(randomiser.Next());
            }

            bubbleSorter.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            bubbleSorter.Sort();


            for (int i = 0; i < 10_000; i++)
            {
                Assert.AreEqual(sorted[i], bubbleSorter.Items[i]);
            }



        }

    }
}
