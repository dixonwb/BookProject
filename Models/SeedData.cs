using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class SeedData
    {
        // This EnsurePopulated method will make sure that the database was built and populated correctly
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            bookDBcontext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<bookDBcontext>();

            // If there are pending migrations, we need to migrate
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            // If there are no books created already, then add the following book objects
            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Fiction = true,
                        Category = "Classic",
                        Price = 9.95
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorLast = "Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Fiction = false,
                        Category = "Biography",
                        Price = 14.58
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Fiction = false,
                        Category = "Biography",
                        Price = 21.54
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorLast = "C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Fiction = false,
                        Category = "Biography",
                        Price = 11.61
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Fiction = false,
                        Category = "Historical",
                        Price = 13.33
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Fiction = true,
                        Category = "Historical Fiction",
                        Price = 15.95
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 14.99
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Fiction = false,
                        Category = "Self-Help",
                        Price = 21.66
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Fiction = false,
                        Category = "Business",
                        Price = 29.16
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Fiction = true,
                        Category = "Thrillers",
                        Price = 15.03
                    }
                );

                // Save changes once the book objects are added
                context.SaveChanges();
            }
        }
    }
}
