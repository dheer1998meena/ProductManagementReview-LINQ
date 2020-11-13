﻿// --------------------------------------------------------------------------------------------------------------------
// <copyrightProductReviewDataTable.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement_LINQ
{
    public class ProductReviewDataTable
    {
        public static DataTable table = new DataTable();
        /// <summary>
        /// UC8 Add data into data table.
        /// </summary>
        public static void AddDataIntoDataTable()
        {

            ///Adding column in DataTable
            table.Columns.Add("ProductId", typeof(Int32));
            table.Columns.Add("UserId", typeof(Int32));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            ///Adding rows in DataTable
            table.Rows.Add(101, 1, 1, "Low", true);
            table.Rows.Add(102, 2, 1, "Low", false);
            table.Rows.Add(103, 3, 4, "Good", true);
            table.Rows.Add(104, 4, 5, "Nice", false);
            table.Rows.Add(105, 5, 4, "Good", true);
            table.Rows.Add(106, 6, 3, "Average", false);
            table.Rows.Add(104, 7, 5, "Nice", true);
            table.Rows.Add(105, 8, 3, "Average", true);
            //UC 12
            table.Rows.Add(103, 10, 2, "Poor", false);
            table.Rows.Add(106, 10, 5, "Nice", true);
            table.Rows.Add(104, 10, 4, "Good", true);
            table.Rows.Add(105, 10, 4, "Good", true);
            //Printing data
            Console.WriteLine("\nDataTable contents:");
            foreach (var list in table.AsEnumerable())
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }

        }
        /// <summary>
        ///  UC9 Retrieves all records whose is like is true.
        /// </summary>
        public static void RetrieveRecordWithTrueIsLike()
        {
            var retrieveData = from records in table.AsEnumerable()
                               where (records.Field<bool>("IsLike") == true)
                               select records;
            //Printing data
            Console.WriteLine("\nRecords in table whose IsLike value is true:");
            foreach (var list in retrieveData)
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }
        }
        /// <summary>
        /// UC10 Finds the average rating for each productId.
        /// </summary>
        public static void FindAverageRatingOfTheEachProductId()
        {
            var records = table.AsEnumerable().GroupBy(r => r.Field<int>("ProductId")).Select(r => new { ProductId = r.Key, Average = r.Average(z => (z.Field<double>("Rating"))) });
            Console.WriteLine("\nProductId and its average rating");
            foreach (var v in records)
            {
                Console.WriteLine($"ProductID:{v.ProductId},AverageRating:{v.Average}");
            }
        }
        /// <summary>
        /// UC11 Retrieves all records with review contains Nice message.
        /// </summary>
        public static void RetrieveRecordsWithReviewContainsNice()
        {
            var retrieveData = from records in table.AsEnumerable()
                               where (records.Field<string>("Review") == "Nice")
                               select records;
            //Printing data
            Console.WriteLine("\nRecords in table Whose Review contains Nice:");
            foreach (var list in retrieveData)
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }
        }
        /// <summary>
        /// UC12 Retrieves the records for given userId sorted by rating.
        /// </summary>
        public static void RetrieveRecordsForGivenUserIdOrderByRating()
        {
            var retrievedData = from records in table.AsEnumerable()
                                where (records.Field<int>("UserId") == 10)
                                orderby records.Field<double>("Rating") descending
                                select records;
            Console.WriteLine("\nSorted records by rating  with userId=10:");
            foreach (var list in retrievedData)
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }
        }
    }
}
