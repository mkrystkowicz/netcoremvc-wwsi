using System;
using System.Collections.Generic;
using Library.Domain;
using Library.Persistence;
namespace Library.ConsoleApp
{
    public class OrderService
    {
        OrdersRepository ordersRepository;
        public OrderService(OrdersRepository _ordersRepository)
        {
            ordersRepository = _ordersRepository;
        }

        public void PlaceOrder()
        {
            Order order = new Order();
            int id, count;

            string input = "";

            while (input != "end")
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. add");
                Console.WriteLine("2. end");

                input = Console.ReadLine();
                Console.Clear();

                if (input == "add")
                {
                    Console.WriteLine("Podaj id ksiazki: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj ilosc: ");
                    count = Convert.ToInt32(Console.ReadLine());

                    BookOrdered book = new BookOrdered(id, count);
                    order.AddOrder(book);

                }
                else if (input == "end")
                {
                    ordersRepository.Insert(order);
                }
            }
        }

        public void ListAll() {
            List<Order> orders = ordersRepository.GetAll();
            orders.ForEach(order => Console.WriteLine(order.ToString()));
        }
    }
}
