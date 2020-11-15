﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewSystem
{
    public class ProductReviewDataTable
    {
        public static DataTable productDataTable = new DataTable();

        /// <summary>
        /// UC 8 : Adds the data into data table.
        /// </summary>
        public static void AddDataIntoDataTable()
        {
            //Adding Fields into the datatable
            productDataTable.Columns.Add("ProductId", typeof(Int32));
            productDataTable.Columns.Add("UserId", typeof(Int32));
            productDataTable.Columns.Add("Rating", typeof(double));
            productDataTable.Columns.Add("Review", typeof(string));
            productDataTable.Columns.Add("IsLike", typeof(bool));

            //Creating rows and Adding data into rows
            productDataTable.Rows.Add(1, 1, 5, "Excellent", true);
            productDataTable.Rows.Add(5, 10, 1, "Poor     ", false);
            productDataTable.Rows.Add(3, 3, 3, "Average  ", true);
            productDataTable.Rows.Add(3, 6, 5, "Excellent", true);
            productDataTable.Rows.Add(2, 2, 4, "Nice     ", true);
            productDataTable.Rows.Add(4, 7, 4, "Nice     ", true);
            productDataTable.Rows.Add(2, 8, 3, "Average  ", true);
            productDataTable.Rows.Add(4, 4, 2, "Satisfactory", false);
            productDataTable.Rows.Add(1, 9, 2, "Satisfactory", false);
            productDataTable.Rows.Add(9, 5, 1, "Poor     ", false);

            //Printing data
            Console.WriteLine("\nDataTable contents:");
            foreach (var v in productDataTable.AsEnumerable())
            {
                Console.WriteLine($"ProductID:{v.Field<int>("ProductId")}\tUserID:{v.Field<int>("UserId")}\tRating:{v.Field<double>("Rating")}\tReview:{v.Field<string>("Review")}\tIsLike:{v.Field<bool>("IsLike")}");
            }
        }
        /// <summary>
        /// Gets all records whose is like is true.
        /// </summary>
        public static void GetAllRecordsWhoseIsLikeIsTrue()
        {
            var data = from records in productDataTable.AsEnumerable()
                       where (records.Field<bool>("IsLike") == true)
                       select records;
            Console.WriteLine("\nRecords in table whose IsLike value is true:");
            foreach (var v in data)
            {
                Console.WriteLine($"ProductID:{v.Field<int>("ProductId")}\tUserID:{v.Field<int>("UserId")}\tRating:{v.Field<double>("Rating")}\tReview:{v.Field<string>("Review")}\tIsLike:{v.Field<bool>("IsLike")}");
            }
        }
    }
}
