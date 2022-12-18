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

        public int getPurchaseAmount()
        {
            return products.Count();
        }

        public double getTotalPurchase()
        {
            double total=0;
            foreach (Product product in products) {
                total = total + product.GetProductDiscount();
            }
            if (products.Count() > 3)
            {
                total = total * 0.9;
            }

            return Math.Round(total,2);
        }

        public void getTotalDiscount()
        {
            
        }
    }
}
