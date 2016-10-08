using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day1Homework.Model
{
    public class Product
    {
        /// <summary>
        /// 商品編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 商品成本
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// 商品毛利
        /// </summary>
        public int Revenue { get; set; }

        /// <summary>
        /// 商品售價
        /// </summary>
        public int SellPrice { get; set; }
    }
}