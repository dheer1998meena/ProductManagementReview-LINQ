﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ProductReviewManagement_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Management Review Program");
            /// UC1 Creating a List of ProductReview and Adding values into List.
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, Review = "Good",     isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 4, Review = "Good",     isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Average",  isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 3, Review = "Average",  isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 6, UserId = 6, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 8, UserId = 7, Rating = 1, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 7, Rating = 5, Review = "Average",  isLike = true }
            };
            foreach (var list in productReviewlist)
            {
                Console.WriteLine("Product Id :" + list.ProductId + "\t" + "User Id :" + list.UserId + "\t" + "Rating ;" + list.Rating + "\t" + "Review :" + list.Review + "\t" + "Is Like :" + list.isLike);
            }
            /// UC2 Retrieve top 3 records from the list who’s rating is high using LINQ
            ProductManagement.RetrieveTopThreeRatedRecords(productReviewlist);
            /// UC3 Retrieves the records with rating greater than three.
            ProductManagement.RetrieveRecordsWithGreaterThanThreeRating(productReviewlist);
            /// UC4 Retrieves the count of reviews for each productID.
            ProductManagement.RetrieveCountOfReviewForEachProductId(productReviewlist);
            /// UC5 Retrieves only the product id and review of all records.
            ProductManagement.RetrieveProductIDAndReviewOfAllRecords(productReviewlist);
            /// UC6 Skip top five records from the list and display other records.
            ProductManagement.SkipTopFiveRecords(productReviewlist);
            /// UC7 Retrieving reviews and productId using the lambda expression syntax.
            ProductManagement.RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist);
            /// UC8 Add data into data table.
            ProductReviewDataTable.AddDataIntoDataTable();
            /// UC9 Retrieves all records whose is like is true.
            ProductReviewDataTable.RetrieveRecordWithTrueIsLike();
            /// UC10 Finds the average rating for each productId.
            ProductReviewDataTable.FindAverageRatingOfTheEachProductId();
            /// UC11 Retrieves all records with review contains Nice message.
            ProductReviewDataTable.RetrieveRecordsWithReviewContainsNice();
            /// UC12 Retrieves the records for given userId sorted by rating.
            ProductReviewDataTable.RetrieveRecordsForGivenUserIdOrderByRating();
            Console.ReadLine();
        }
    }
}

