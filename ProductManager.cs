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
    }
}
