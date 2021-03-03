using BookProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r; // we need to pass the repository to the navigation menu component in order to access the elements we are interested in
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"]; // we are going to make the selected category equal to whatever category is in the url

            return View(repository.Books
                .Select(x => x.Category) // this is the same as an SQL SELECT statemtent
                .Distinct() // SELECT DISTINCT Category FROM Books
                .OrderBy(x => x));
        }

    }
}
