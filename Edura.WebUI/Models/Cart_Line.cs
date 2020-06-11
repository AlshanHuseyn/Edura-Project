using Edura.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Edura.WebUI.Models
{
    public class Cart_
    {
        private List<Cart_Line> products = new List<Cart_Line>();
        public List<Cart_Line> Products => products;

        public void AddProduct(Product product, int quantity)
        {
            var prd = products
                .Where(m => m.Product.ProductId == product.ProductId)
                .FirstOrDefault();

            if (prd == null)
            {
                products.Add(new Cart_Line()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }

        public void RemoveProduct(Product product)
        {
            products.RemoveAll(m => m.Product.ProductId == product.ProductId);
        }

        public double TotalPrice()
        {
            return products.Sum(m => m.Product.Price * m.Quantity);
        }

        public void ClearAll()
        {
            products.Clear();
        }
    }

    public class Cart_Line
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
