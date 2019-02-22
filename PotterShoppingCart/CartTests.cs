using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void GetTotalPrize_Buy_Nothing_Should_return_0()
        {
            //Arrange
            var cart = new Cart();
            var books = new List<Book>();

            //Act
            var actual = cart.GetTotalPrize(books);

            //Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GetTotalPrize_Buy_One_EP1_Should_return_100()
        {
            //Arrange
            var cart = new Cart();
            var books = new List<Book> { new Book() { ISBN = "1" } };

            //Act
            var actual = cart.GetTotalPrize(books);

            //Assert
            Assert.AreEqual(100, actual);
        }


    }

    public class Book
    {
        public string ISBN { get; set; }
    }

    public class Cart
    {
        public int GetTotalPrize(List<Book> books)
        {
            if (books.Count == 1)
            {
                return 100;
            }
            return 0;
        }
    }
}
