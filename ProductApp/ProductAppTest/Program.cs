using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProductApp;

namespace ProductAppTest
{
    public class ProductAppUnitTest
    {
        static void Main(string[] args)
        {
        }

        // Tests for ProductID
        [Test]
        public void ProductID_SetAndGetProductID_ReturnsCorrectID()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 10);
            int expected = 10;

            // Act
            int actual = product.ProductID;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ProductID_SetMinimumValue_ReturnsMinimumValue()
        {
            // Arrange
            var product = new Product(6, "Product Test", 100.00m, 10);
            int expected = 6;

            // Act
            int actual = product.ProductID;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ProductID_SetMaximumValue_ReturnsMaximumValue()
        {
            // Arrange
            var product = new Product(60000, "Product Test", 100.00m, 10);
            int expected = 60000;

            // Act
            int actual = product.ProductID;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        // Tests for ProductName
        [Test]
        public void ProductName_SetAndGetProductName_ReturnsCorrectName()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 10);
            string expected = "Product Test";

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ProductName_SetEmptyName_ReturnsEmptyName()
        {
            // Arrange
            var product = new Product(10, "", 100.00m, 10);
            string expected = "";

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ProductName_SetNullName_ReturnsNullName()
        {
            // Arrangetest Product
            var product = new Product(10, null, 100.00m, 10);
            string expected = null;

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        // Tests for Price
        [Test]
        public void Price_SetAndGetPrice_ReturnsCorrectPrice()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 10);
            decimal expected = 100.00m;

            // Act
            decimal actual = product.Price;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Price_SetMinimumValue_ReturnsMinimumValue()
        {
            // Arrange
            var product = new Product(10, "Product Test", 6.00m, 10);
            decimal expected = 6.00m;

            // Act
            decimal actual = product.Price;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Price_SetMaximumValue_ReturnsMaximumValue()
        {
            // Arrange
            var product = new Product(10, "Product Test", 6000.00m, 10);
            decimal expected = 6000.00m;

            // Act
            decimal actual = product.Price;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Tests for Stock
        [Test]
        public void Stock_SetAndGetStock_ReturnsCorrectStock()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 100);
            int expected = 100;

            // Act
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Stock_SetMinimumValue_ReturnsMinimumValue()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 6);
            int expected = 6;

            // Act
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void Stock_SetMaximumValue_ReturnsMaximumValue()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 600000);
            int expected = 600000;

            // Act
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }



        // Tests for IncreaseStock
        [Test]
        public void IncreaseStock_5Amount_IncreasesStock()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 10);
            int amount = 5;
            int expected = 15;

            // Act
            product.IncreaseStock(amount);
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IncreaseStock_IncreaseToMaximumValue_IncreasesStockToMax()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 6);
            int amount = 599994;
            int expected = 600000;

            // Act
            product.IncreaseStock(amount);
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void IncreaseStock_ByZeroStock_StockRemainsUnchanged()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 10);
            int amount = 0;
            int expected = 10;

            // Act
            product.IncreaseStock(amount);
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Tests for DecreaseStock
        [Test]
        public void DecreaseStock_4Amount_DecreasesStock()
        {
            var product = new Product(10, "Test Product", 100.00m, 20);
            int amount = 4;
            int expected = 16;

            product.DecreaseStock(amount);
            int actual = product.Stock;

            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void DecreaseStock_DecreaseToMinimumValue_DecreasesStockToMin()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 600000);
            int amount = 599994;
            int expected = 6;

            // Act
            product.DecreaseStock(amount);
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DecreaseStock_ByZeroStock_StockRemainsUnchanged()
        {
            // Arrange
            var product = new Product(10, "Product Test", 100.00m, 10);
            int amount = 0;
            int expected = 10;

            // Act
            product.DecreaseStock(amount);
            int actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
