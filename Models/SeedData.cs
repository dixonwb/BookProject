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
                        NumPages = 1488,
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
                        NumPages = 944,
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
                        NumPages = 832,
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
                        NumPages = 864,
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
                        NumPages = 528,
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
                        NumPages = 288,
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
                        NumPages = 304,
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
                        NumPages = 240,
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
                        NumPages = 400,
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
                        NumPages = 642,
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Fiction = true,
                        Category = "Thrillers",
                        Price = 15.03
                    },

                    new Book
                    {
                        Title = "To Kill A Mockingbird",
                        NumPages = 281,
                        AuthorFirst = "Harper",
                        AuthorLast = "Lee",
                        Publisher = "J.B. Lippincott & Co.",
                        ISBN = "953-1078643217",
                        Fiction = true,
                        Category = "Historical Fiction",
                        Price = 15.99
                    },

                    new Book
                    {
                        Title = "All Quiet on the Western Front",
                        NumPages = 200,
                        AuthorFirst = "Erich",
                        AuthorLast = "Remarque",
                        Publisher = "Ullstein Verlag",
                        ISBN = "978-5533689125",
                        Fiction = true,
                        Category = "Historical Fiction",
                        Price = 5.93
                    },


                    new Book
                    {
                        Title = "Harry Potter and the Sorcerer's Stone",
                        NumPages = 223,
                        AuthorFirst = "J.K.",
                        AuthorLast = "Rowling",
                        Publisher = "Scholastic Corporation",
                        ISBN = "962-8097536411",
                        Fiction = true,
                        Category = "Fantasy",
                        Price = 6.98
                    }
                );

                // Save changes once the book objects are added
                context.SaveChanges();
            }
        }
    }
}
