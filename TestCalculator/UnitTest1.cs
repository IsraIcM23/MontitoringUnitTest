using Calculator;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_GetCorrectDiscount_PerProduct()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.Discount = 20;
            double actual = item1.GetProductDiscount();
            // Ex. 10 * 0.20 = 8
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestMethod_GetCorrectDiscount_WithOut_Discount()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.Discount = 0;
            double actual = item1.GetProductDiscount();
            //Ex. 10 * 0.05 = 9.5
            Assert.AreEqual(9.5, actual);
        }

        [TestMethod]
        public void TestMethod_GetCorrectDiscount_PerPurchase()
        {
            Product item1 = new Product();
            Product item2 = new Product();
            Product item3 = new Product();
            Product item4 = new Product();

            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.Discount = 10;

            item2.ItemName = "Libro2";
            item2.Price = 20;
            item2.Discount = 50;

            item3.ItemName = "Libro3";
            item3.Price = 100;
            item3.Discount = 60;

            item4.ItemName = "Libro4";
            item4.Price = 200;
            item4.Discount = 50;

            Purchase purchase1 = new Purchase();

            purchase1.products.Add(item1);
            purchase1.products.Add(item2);
            purchase1.products.Add(item3);
            purchase1.products.Add(item4);

            int purchaseAmount = purchase1.getPurchaseAmount();

            Assert.AreEqual(4, purchaseAmount);
        }

        [TestMethod]
        public void TestMethod_GetTotalPurchaseMore3Products()
        {
            Product item1 = new Product();
            Product item2 = new Product();
            Product item3 = new Product();
            Product item4 = new Product();

            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.Discount = 10;

            item2.ItemName = "Libro2";
            item2.Price = 20;
            item2.Discount = 50;

            item3.ItemName = "Libro3";
            item3.Price = 100;
            item3.Discount = 60;

            item4.ItemName = "Libro4";
            item4.Price = 200;
            item4.Discount = 50;

            Purchase purchase1 = new Purchase();

            purchase1.products.Add(item1);
            purchase1.products.Add(item2);
            purchase1.products.Add(item3);
            purchase1.products.Add(item4);

            //Ex. 9+10+40+100=159*0.9 => 143.1

            double totalPurchase = purchase1.getTotalPurchase();

            Assert.AreEqual(143.1, totalPurchase);
        }

        [TestMethod]
        public void TestMethod_GetTotalPurchaseLessOrEqual3Products()
        {
            Product item1 = new Product();
            Product item2 = new Product();
            Product item3 = new Product();

            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.Discount = 10;

            item2.ItemName = "Libro2";
            item2.Price = 20;
            item2.Discount = 50;

            item3.ItemName = "Libro3";
            item3.Price = 100;
            item3.Discount = 60;



            Purchase purchase1 = new Purchase();

            purchase1.products.Add(item1);
            purchase1.products.Add(item2);
            purchase1.products.Add(item3);

            //EX. 9+10+40=59

            double totalPurchase = purchase1.getTotalPurchase();

            Assert.AreEqual(59, totalPurchase);
        }

    }
}