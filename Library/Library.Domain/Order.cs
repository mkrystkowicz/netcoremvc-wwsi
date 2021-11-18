using System;
using System.Collections.Generic;

namespace Library.Domain
{
    public class Order
    {
        DateTime Date;
        public List<BookOrdered> BooksOrderedList;

        public override string ToString()
        {
            return $"Order: {Date} \n Count: {BooksOrderedList}";
        }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }

        public void AddOrder(BookOrdered order) => BooksOrderedList.Add(order);
    }
}
