using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class Cart
    {
        private int _basicPrize = 100;

        private Dictionary<int, double> _discount = new Dictionary<int, double>
        {
            {0, 0}, {1, 1}, {2, 0.95},{3, 0.9}
        };

        public int GetTotalPrize(List<Book> books)
        {
            var totalPrize = _basicPrize * books.Count;
            return (int)(totalPrize * _discount[books.Count]);
        }
    }
}