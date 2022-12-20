using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Purchase
    {
        public double TotalAmount;
        public int TotalDiscount;
        public List<Product> products = new List<Product>();

        
        public double getTotalPurchase()
        {
            double total=0;
            foreach (Product product in products) {
                total = total + product.GetProductPriceWithDiscount();
            }
            if (products.Count() > 3)
            {
                total = total * 0.9;
            }

            return Math.Round(total,2);
        }
        public double getTotalDiscountPerPurchase()
        {
            double totalDiscount = 0;
            double totalWithOutDiscount = 0;
            foreach (Product product in products)
            {
                totalDiscount = totalDiscount + product.GetProductDiscount();
                if(products.Count() > 6 && product.DiscountRate==0) {
                    totalWithOutDiscount = totalWithOutDiscount + (product.Price*0.07);
                }
                else totalWithOutDiscount = totalWithOutDiscount + product.Price;
            }
            if (products.Count() > 3)
            {
                totalDiscount = totalDiscount + (totalWithOutDiscount * 0.1);
            }

            return Math.Round(totalDiscount, 2);
        }

        public void getTotalDiscount()
        {
            
        }
    }
}
