using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This class will hold several lines (think of list items) of books and quantities and prices

namespace BookProject.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>(); // We are going to start a new list of lines
        
        // Methods
        ///
        public void AddItem(Book boo, int qty)
        {
            CartLine line = Lines.Where(b => b.Book.BookID == boo.BookID).FirstOrDefault(); 

            if (line == null)
            {
                Lines.Add(new CartLine { Book = boo, Quantity = qty });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        // We want to be able to remove a book
        public void RemoveLine(Book boo) =>
            Lines.RemoveAll(x => x.Book.BookID == boo.BookID);

        // This will clear everything from the cart
        public void Clear() => Lines.Clear();

        // This will compute the total of all items in the cart
        public decimal ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);
        
        // We create a class within a class
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
