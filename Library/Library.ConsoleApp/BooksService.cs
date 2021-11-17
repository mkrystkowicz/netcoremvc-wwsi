using System;
using System.Collections.Generic;
using Library.Domain;
using Library.Persistence;

namespace Library.ConsoleApp
{
    public class BooksService
    {
        BooksRepository _repository;
        public BooksService(BooksRepository booksRepository) {
            _repository = booksRepository;
        }

        public void AddBook()
        {
            Console.WriteLine("Podaj tytul");
            string title = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            string author = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania");
            int publicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Podaj ilosc dostepnych ksiazek");
            int productsAvailable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cene");
            decimal price = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(title, author, publicationYear, isbn, productsAvailable, price);
            _repository.Insert(book);
        }

        public void RemoveBook()
        {
            Console.WriteLine("Podaj tytul");
            string title = Console.ReadLine();

            _repository.RemoveByTitle(title);
        }

        public void ListBook()
        {
            List<Book> books = _repository.GetAll();
            books.ForEach(book => Console.WriteLine($"   {book.Author} - {book.Title} ({book.PublicationYear}) - dostepnych: {book.ProductsAvailable}"));
        }

        public void ChangeState()
        {
            Console.WriteLine("Podaj tytul");
            string title = Console.ReadLine();
            Console.WriteLine("Podaj stan");
            int state = Convert.ToInt32(Console.ReadLine());

            _repository.ChangeState(title, state);
        }
    }
}
