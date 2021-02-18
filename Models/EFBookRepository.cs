using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    // First creat the repository class and then the constructor
    public class EFBookRepository : IBookRepository
    {
        private bookDBcontext _context;
        
        // Constructor for the repository
        public EFBookRepository (bookDBcontext context)
        {
            _context = context;
        }

        // This lambda (=>) assignment sort of acts like a dynamic variable (it'll update automatically)
        public IQueryable<Book> Books => _context.Books;
    }
}
