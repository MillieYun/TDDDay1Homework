﻿using System.Collections.Generic;
using System.Linq;
using Day1Homework.Helpers;
using Day1Homework.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Homework.Tests
{
    [TestClass]
    public class CalculateProductCollectionTest
    {
        [TestMethod()]
        public void SumCostByGroup3()
        {
            // arrange
            var target = new CalculateHelper();
            var products = GetProductList();
            int groupCount = 3;
            var expected = new List<int>() { 6, 15, 24, 21 };

            // act
            var actual = target.SumByGroup(products.OrderBy(p => p.Id).Select(p => p.Cost).ToList(), groupCount);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumRevenueByGroup4()
        {
            // arrange
            var target = new CalculateHelper();
            var products = GetProductList();
            int groupCount = 4;
            var expected = new int[] { 50, 66, 60 };

            // act
            var actual = target.SumByGroup(products.OrderBy(p => p.Id).Select(p => p.Revenue).ToList(), groupCount);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }


        private List<Product> GetProductList()
        {
            return new List<Product>()
            {
                new Product() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Product() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Product() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Product() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Product() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Product() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Product() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Product() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Product() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Product() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Product() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
        }
    }
}
