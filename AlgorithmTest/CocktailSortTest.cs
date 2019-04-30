using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorter.Sort;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    [TestClass]
    public class CocktailSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            var cocktailSorter = new CocktailSort<int>();
            var randomiser = new Random();
            var items = new List<int>();

            for (int i = 0; i < 10_000; i++)
            {
                items.Add(randomiser.Next());
            }

            cocktailSorter.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            cocktailSorter.Sort();


            for (int i = 0; i < 10_000; i++)
            {
                Assert.AreEqual(sorted[i], cocktailSorter.Items[i]);
            }



        }
    }
}
