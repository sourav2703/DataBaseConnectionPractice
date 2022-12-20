using DB_And_Table_Creation.Data;
using DB_And_Table_Creation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_And_Table_Creation.BookRepo
{
    public class BookRepositry
    {
        private readonly BookContext _bookContext = null;
        public BookRepositry(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        public int AddNewBook(BookModel model)
        {
            var book = new BookModel()
            {
                Title = model.Title
            };

            _bookContext.Add(book);
            _bookContext.SaveChanges();
            return book.Id;
        }

       
    }
}
