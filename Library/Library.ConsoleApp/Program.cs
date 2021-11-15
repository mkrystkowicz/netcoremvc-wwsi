﻿using System;
using Library.Domain;
using Library.Persistence;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1

            Book book = new Book("Wzgórze psów", "Jakub Żulczyk", 2017, "9788380313507", 113, 29);
            BooksRepository repository = new BooksRepository();

            // Program skompilowal sie poprawnie

            // Zadanie 2

            Console.WriteLine("Podaj login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj haslo: ");
            string haslo = Console.ReadLine();

            if (login == "Admin" && haslo == "password")
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }

            // Program wykonuje sie poprawnie podczas podania login: Admin i haslo: password otrzymujemy komunikat: Access Granted
            // W przeciwnym razie Acces Denied

            // Zadanie 3

            string input = "";

            while (input != "wyjdz")
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. dodaj");
                Console.WriteLine("2. usun");
                Console.WriteLine("3. wypisz");
                Console.WriteLine("4. zmien");
                Console.WriteLine("5. dodaj zamowienie");
                Console.WriteLine("6. lista zamowien");
                Console.WriteLine("Wpisz odpowiednia komende:");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "dodaj")
                {
                    Console.WriteLine("proba dodania ksiazki");
                }
                else if (input == "usun")
                {
                    Console.WriteLine("proba usuniecia ksiazki");
                }
                else if (input == "wypisz")
                {
                    Console.WriteLine("proba wypisania wszystkich ksiazek");
                }
                else if (input == "zmien")
                {
                    Console.WriteLine("proba zmiany stany magazynowego ksiazek");
                }
                else if (input == "dodaj zamowienie")
                {
                    Console.WriteLine("proba dodania nowego zamowienia");
                }
                else if (input == "lista zamowien")
                {
                    Console.WriteLine("proba wypisania wszystkich zamowien");
                }
            }
        }
    }
}

















