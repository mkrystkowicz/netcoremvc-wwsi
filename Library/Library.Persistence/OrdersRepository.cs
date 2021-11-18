using System;
using System.Collections.Generic;
using Library.Domain;

namespace Library.Persistence
{
    public class OrdersRepository
    {
        List<Order> database = new List<Order>();
        public OrdersRepository()
        {
        }

        public void Insert(Order order)
        {
            database.Add(order);
        }

        public List<Order> GetAll()
        {
            return database;
        }
    }
}
