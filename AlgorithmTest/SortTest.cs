using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Sorter.Sort;

namespace AlgorithmTest
{
    [TestClass]
    public class SortTest
    {
        Random randomiser = new Random();
        List<int> sorted = new List<int>();
        List<int> items = new List<int>();

        [TestInitialize]
        public void Init()
        {
            items.Clear();

            for (int i = 0; i < 10_000; i++)
            {
                items.Add(randomiser.Next());
            }

            sorted.Clear();
            sorted.AddRange(items.OrderBy(x => x).ToArray());
        }


        [TestMethod]
        public void BaseSortTest()
        {
            var basesort = new AlgorithmBase<int>();
            basesort.Items.AddRange(items);

            basesort.Sort();

            for (int i = 0; i < 10_000; i++)
                Assert.AreEqual(sorted[i], basesort.Items[i]);

        }


        [TestMethod]
        public void BubbleSortTest()
        {
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(items);

            bubble.Sort();

            for (int i = 0; i < 10_000; i++)
                Assert.AreEqual(sorted[i], bubble.Items[i]);

        }


        [TestMethod]
        public void CocktailSortTest()
        {
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(items);

            cocktail.Sort();

            for (int i = 0; i < 10_000; i++)
                Assert.AreEqual(sorted[i], cocktail.Items[i]);

        }

    }
}
