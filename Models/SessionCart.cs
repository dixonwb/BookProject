using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using BookProject.Infrastructure;

namespace BookProject.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }
        public virtual void AddItem(Book boo, int quantity)
        {
            base.AddItem(boo, quantity);
            Session.SetJson("cart", this);
        }
        public virtual void RemoveLine(Book boo)
        {
            base.RemoveLine(boo);
            Session.SetJson("cart", this);
        }
        public virtual void Clear()
        {
            base.Clear();
            Session.Remove("cart");
        }
    }
}
