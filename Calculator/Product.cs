namespace Calculator
{
    public class Product
    {
        public string ?ItemName { get; set; }
        public double Price { get; set; }
        public double DiscountRate { get; set; }

        public double GetProductDiscount()
        {
            if (this.DiscountRate == 0)
            {
                this.DiscountRate = 5;
            }
            return this.Price * (this.DiscountRate / 100);
        }
        public double GetProductPriceWithDiscount(){
            if (this.DiscountRate == 0)
            {
                this.DiscountRate = 5;
            }
            return (this.Price - GetProductDiscount());
        }
        

    }
}