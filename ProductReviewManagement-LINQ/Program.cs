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
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 1, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 3, Review = "Average",  isLike = true }
            };
            foreach (var list in productReviewlist)
            {
                Console.WriteLine("Product Id :" + list.ProductId + "\t" + "User Id :" + list.UserId + "\t" + "Rating ;" + list.Rating + "\t" + "Review :" + list.Review + "\t" + "Is Like :" + list.isLike);
            }

        }
    }
}

