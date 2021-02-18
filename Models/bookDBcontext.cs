using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class bookDBcontext : DbContext
    {
        // We want the bookDBcontext to inherit from the base options
        public bookDBcontext (DbContextOptions<bookDBcontext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
