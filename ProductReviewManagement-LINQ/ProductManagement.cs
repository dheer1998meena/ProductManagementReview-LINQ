// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductManagement.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement_LINQ
{
    public class ProductManagement
    {
        /// <summary>
        /// UC2 Retrieve top 3 records from the list who’s rating is high using LINQ
        /// </summary>
        /// <param name="list"></param>
        public static void RetrieveTopThreeRatedRecords(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                 orderby products.Rating descending
                                 select products).Take(3);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating ;" + productReview.Rating + "\t" + "Review :" + productReview .Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
    }
}