using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class BookListService
    {

        private List<Book> books;

        public BookListService()
        {

        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException("The book to be added is null!");
            if (books.Contains(book))
                throw new ArgumentException("The book already exists!");
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException("The book to be removed is null!");
            if (!books.Contains(book))
                throw new ArgumentException("The book is no such book in the storage!");
            books.Remove(book);
        }

        public void FindBookByTag()
        {

        }

        public void SortBooksByTag()
        {
        }
    }
}
