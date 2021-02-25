using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models.ViewModels
{
    public class BookListViewModel
    {
        // We need to pass our IEnumerable list of books and paging info objects here
        // because you cannot @model multiple models at the top of Index.cshtml
        // If we just pass Books and PagingInfo into BookListView Model and pass
        // BookListViewModel to Index.cshtml, then we solve our problem
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
