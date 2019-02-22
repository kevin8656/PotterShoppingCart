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
            var books = new List<Book>();

            TotalPrizeShouldBe(0, books);
        }

        private static void TotalPrizeShouldBe(int expected, List<Book> books)
        {
            var cart = new Cart();
            var actual = cart.GetTotalPrize(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalPrize_Buy_One_EP1_Should_return_100()
        {
            var books = new List<Book> { new Book() { ISBN = "1" } };
            TotalPrizeShouldBe(100, books);
        }


    }

    public class Book
    {
        public string ISBN { get; set; }
    }

    public class Cart
    {
        private int _basicPrize = 100;

        public int GetTotalPrize(List<Book> books)
        {
            if (books.Count == 1)
            {
                return _basicPrize;
            }
            return 0;
        }
    }
}
