using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private BooksDbContext _context;

        //constructor
        public EFBooksRepository (BooksDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> books => _context.Books;
    }
}
