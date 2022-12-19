using Calculator;
using System.Net.Http.Headers;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcDiscountPerItemValidRetirnsDiscountAmount()
        {
            Product item1 = new Product();
            item1.ItemName = "Libro1";
            item1.Price = 10;
            item1.Discount = 10;
            double actual = item1.GetTotalDiscount();

            Assert.AreEqual(9, actual);
        }
        /*[TestMethod]
        public void T()
        {
            Purchase purchase1 = new Purchase();
            purchase1.products = item1;
            .Price = 10;
            item1.Discount = 10;
            double actual = item1.GetTotalDiscount();

            Assert.AreEqual(9, actual);
        }
        /*product item1 = new Product("libro 1", 10, 10);
            product item2 = new Product("libro 2", 10, 15);
            compra myPurchase = new Purchase();
            myPurchase.Add(item1)
            myPurchase.Add(item2)
            int discount = 0;
            discount = myPurchase.UpdateDiscount(); [|| discount = muPurchase.totalDiscount;]
            Assert(discount, 2.5)*/
    }
}