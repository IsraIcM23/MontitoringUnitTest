namespace Calculator
{
    public class Product
    {
        public string ?ItemName { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public double GetProductDiscount()
        {
            if (this.Discount == 0)
            {
                this.Discount = 5;
            }
            return (this.Price - (this.Price * (this.Discount / 100)));
        }

    }
}