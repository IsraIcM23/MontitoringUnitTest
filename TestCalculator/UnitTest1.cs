using Calculator;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetDiscountPerProductWithAsignedDiscountRate()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 20;
            double actual = item1.GetProductDiscount();
            // Ex. 10 * 0.20 = 2
            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void TestMethodGetDiscountPerProductWithOutAsignedDiscountRate()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 0;
            double actual = item1.GetProductDiscount();
            // Ex. 10 * 0.05 = 0.5
            Assert.AreEqual(0.5, actual);
        }
        [TestMethod]
        public void TestMethodGetTotalPerProductWithDiscountRate()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 20;
            double actual = item1.GetProductPriceWithDiscount();
            //Ex. 10 * 0.2 = 2  =>  10 - 2 = 8
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestMethodGetTotalPerProductWithOutDiscountRate()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 0;
            double actual = item1.GetProductPriceWithDiscount();
            //Ex. 10 * 0.05 = 0.5  =>  10 - 0.5=9.5
            Assert.AreEqual(9.5, actual);
        }

        [TestMethod]
        public void TestMethodGetTotalDiscountPerPurchaseMore3ProductsAndLess6Products()
        {
            Product item1 = new Product();
            Product item2 = new Product();
            Product item3 = new Product();
            Product item4 = new Product();

            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 10;

            item2.ItemName = "Libro2";
            item2.Price = 10;
            item2.DiscountRate = 15;

            item3.ItemName = "Libro3";
            item3.Price = 10;
            item3.DiscountRate = 20;

            item4.ItemName = "Libro4";
            item4.Price = 10;
            item4.DiscountRate = 30;

            Purchase purchase1 = new Purchase();

            purchase1.products.Add(item1);
            purchase1.products.Add(item2);
            purchase1.products.Add(item3);
            purchase1.products.Add(item4);

            //Ex. 1+1.5+2+3 = 7.5  ;   40*0.1=4    ;   7.5+4 = 11.5
            double totalDiscountPerPurchase = purchase1.getTotalDiscountPerPurchase(); 

            Assert.AreEqual(11.5, totalDiscountPerPurchase);
        }
        
        [TestMethod]
        public void TestMethodGetTotalDiscountPerPurchaseLessOrEqual3Products()
        {
            Product item1 = new Product();
            Product item2 = new Product();
            Product item3 = new Product();
            
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 10;

            item2.ItemName = "Libro2";
            item2.Price = 10;
            item2.DiscountRate = 15;

            item3.ItemName = "Libro3";
            item3.Price = 10;
            item3.DiscountRate = 20;
                       
            Purchase purchase1 = new Purchase();

            purchase1.products.Add(item1);
            purchase1.products.Add(item2);
            purchase1.products.Add(item3);
                        
            //Ex. 1+1.5+2 = 4.5  ;   
            double totalDiscountPerPurchase = purchase1.getTotalDiscountPerPurchase();

            Assert.AreEqual(4.5, totalDiscountPerPurchase);
        }
        [TestMethod]
        public void TestMethodGetTotalDiscountPerPurchaseMore6Products()
        {
            Product item1 = new Product();
            Product item2 = new Product();
            Product item3 = new Product();
            Product item4 = new Product();
            Product item5 = new Product();
            Product item6 = new Product();
            Product item7 = new Product();

            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.DiscountRate = 10;

            item2.ItemName = "Libro2";
            item2.Price = 10;
            item2.DiscountRate = 15;

            item3.ItemName = "Libro3";
            item3.Price = 10;
            item3.DiscountRate = 20;

            item4.ItemName = "Libro4";
            item4.Price = 10;
            item4.DiscountRate = 30;

            item5.ItemName = "Libro5";
            item5.Price = 10;
            item5.DiscountRate = 40;

            item6.ItemName = "Libro6";
            item6.Price = 10;
            item6.DiscountRate = 50;

            item7.ItemName = "Libro7";
            item7.Price = 10;
            item7.DiscountRate = 7;

            Purchase purchase1 = new Purchase();

            purchase1.products.Add(item1);
            purchase1.products.Add(item2);
            purchase1.products.Add(item3);
            purchase1.products.Add(item4);
            purchase1.products.Add(item5);
            purchase1.products.Add(item6);
            purchase1.products.Add(item7);

            //Ex. 1+1.5+2+3+4+5+(0,7) = 17.2  ;   70*0.1=7    ;   17.2 +7 = 24.2
            double totalDiscountPerPurchase = purchase1.getTotalDiscountPerPurchase();

            Assert.AreEqual(24.2, totalDiscountPerPurchase);
        }

       

    }
}