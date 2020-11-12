﻿// --------------------------------------------------------------------------------------------------------------------
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
            Console.WriteLine("\nTop 3 high rated products are:");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating ;" + productReview.Rating + "\t" + "Review :" + productReview .Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
        /// <summary>
        /// UC3 Retrieves the records with rating greater than three.
        /// </summary>
        /// <param name="list"></param>
        public static void RetrieveRecordsWithGreaterThanThreeRating(List<ProductReview> list)
        {
            var recordedData = (from productReviews in list
                                where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                                && productReviews.Rating > 3
                                select productReviews);
            Console.WriteLine("\nProducts with rating greater than 3 and id=1 or 4 or 9 are:");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating ;" + productReview.Rating + "\t" + "Review :" + productReview.Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
    }
}