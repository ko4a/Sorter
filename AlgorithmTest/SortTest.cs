using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


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


    }
}
