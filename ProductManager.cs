using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewSystem
{
    public class ProductManager
    {
        /// <summary>
        /// Gets the top three high rated products.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void GetTopThreeHighRatedproducts(List<ProductReview> productList)
        {
           var data = (from products in productList
                                 orderby products.Rating descending
                                 select products).Take(3);
            Console.WriteLine("\nTop 3 high rated products are:");
            foreach (var v in data)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
        }
        /// <summary>
        /// Gets the records with rating greater than three.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void GetRecordsWithRatingGreaterThanThree(List<ProductReview> productList)
        {
            var data = productList.Where(r => r.Rating > 3 && (r.ProductID == 1 || r.ProductID == 4 || r.ProductID == 9)).ToList();
            Console.WriteLine("\nProducts with rating greater than 3 and id=1 or 4 or 9 are:");
            foreach (var v in data)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
        }
        /// <summary>
        /// Gets the count of reviews for each product identifier.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void GetCountOfReviewsForEachProductID(List<ProductReview> productList)
        {
            var data = (from products in productList
                                 group products by products.ProductID into g
                                 select new { ProductID = g.Key, Count = g.Count() });
            Console.WriteLine("ProductId and their review count:");
            foreach (var v in data)
            {
                Console.WriteLine($"ProductID:{v.ProductID},ReviewCount:{v.Count}");
            }
        }
    }
}
