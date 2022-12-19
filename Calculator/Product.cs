using System.Diagnostics;

namespace Calculator
{
    public class Product
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }

        public double GetTotalDiscount()
        {
            return (this.Price - (this.Price * (this.Discount/100)));
        }
    }
}