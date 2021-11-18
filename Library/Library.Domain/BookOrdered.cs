using System;
namespace Library.Domain
{
    public class BookOrdered
    {
        int BookId;
        int NumberOrdered;

        public BookOrdered(int id, int nr)
        {
            this.BookId = id;
            this.NumberOrdered = nr;
        }
    }
}
