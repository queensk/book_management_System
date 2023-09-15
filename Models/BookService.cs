using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_management_System.Models
{
    public class BookService
    {
        private List<Book> _books = new List<Book>();

        public List<Book> GetAll()
        {
            return _books;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }


        public Book GetBook(Guid id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBook(Book book)
        {
            var index = _books.IndexOf(book);
            if (index >= 0)
            {
                _books[index] = book;
            }
        }

        public void DeleteBook(Book book)
        {
            _books.Remove(book);
        }  
    }
}