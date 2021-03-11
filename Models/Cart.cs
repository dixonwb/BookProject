using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

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

        public void RemoveLine(Book boo) =>
            Lines.RemoveAll(x => x.Book.BookID == boo.BookID);

        public void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);
        

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
