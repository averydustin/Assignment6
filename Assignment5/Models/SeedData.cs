using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BooksDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BooksDbContext>();



            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange
                    (
                        new Book
                        {
                            
                            Title = "Les Miserables",
                            AuthFirst = "Victor",
                            AuthLast = "Hugo",
                            Publisher = "Signet",
                            ISBN = 9780451419439,
                            Classif = "Fiction",
                            Category = "Classic",
                            Price = 9.95,
                            PageCount = 1488
                            
                        },
                        new Book
                        {
                            
                            Title = "Team of Rivals",
                            AuthFirst = "Doris Kearns",
                            AuthLast = "Goodwin",
                            Publisher = "Simon and Schuster",
                            ISBN = 9780743270755,
                            Classif = "Non-Fiction",
                            Category = "Biography",
                            Price = 14.58,
                            PageCount = 944
                        },
                        new Book
                        {
                            
                            Title = "The Snowball",
                            AuthFirst = "Alice",
                            AuthLast = "Schroeder",
                            Publisher = "Bantam",
                            ISBN = 9780553384611,
                            Classif = "Non-Fiction",
                            Category = "Biography",
                            Price = 21.54,
                            PageCount = 832
                        },
                        new Book
                        {
                            
                            Title = "American Ulysses",
                            AuthFirst = "Ronald C.",
                            AuthLast = "White",
                            Publisher = "Random House",
                            ISBN = 9780812981254,
                            Classif = "Non-Fiction",
                            Category = "Biography",
                            Price = 11.61,
                            PageCount = 864
                        },
                        new Book
                        {
                            
                            Title = "Unbroken",
                            AuthFirst = "Laura",
                            AuthLast = "Hillenbrand",
                            Publisher = "Random House",
                            ISBN = 9780812974492,
                            Classif = "Non-Fiction",
                            Category = "Historical",
                            Price = 13.33,
                            PageCount = 528
                        },
                        new Book
                        {
                            
                            Title = "The Great Train Robbery",
                            AuthFirst = "Michael",
                            AuthLast = "Crichton",
                            Publisher = "Vintage",
                            ISBN = 9780804171281,
                            Classif = "Fiction",
                            Category = "Historical Fiction",
                            Price = 15.95,
                            PageCount = 288
                        },
                        new Book
                        {
                            
                            Title = "Deep Work",
                            AuthFirst = "Cal",
                            AuthLast = "Newport",
                            Publisher = "Grand Central Publishing",
                            ISBN = 9781455586691,
                            Classif = "Non-Fiction",
                            Category = "Self-Help",
                            Price = 14.99,
                            PageCount = 304
                        },
                        new Book
                        {
                            
                            Title = "It's Your Ship",
                            AuthFirst = "Michael",
                            AuthLast = "Abrashoff",
                            Publisher = "Grand Central Publishing",
                            ISBN = 9781455523023,
                            Classif = "Non-Fiction",
                            Category = "Self-Help",
                            Price = 21.66, 
                            PageCount = 240
                        },
                        new Book
                        {
                            
                            Title = "The Virgin Way",
                            AuthFirst = "Richard",
                            AuthLast = "Branson",
                            Publisher = "Portfolio",
                            ISBN = 9781591847984,
                            Classif = "Non-Fiction",
                            Category = "Business",
                            Price = 29.16,
                            PageCount = 400
                        },
                        new Book
                        {
                            
                            Title = "Sycamore Row",
                            AuthFirst = "John",
                            AuthLast = "Grisham",
                            Publisher = "Bantam",
                            ISBN = 9780553393613,
                            Classif = "Fiction",
                            Category = "Thrillers",
                            Price = 15.03, 
                            PageCount = 642
                        },
                        new Book
                        {
                            Title = "Anxious People",
                            AuthFirst = "Frederick",
                            AuthLast = "Backman", 
                            Publisher = "Simon and Schuster",
                            ISBN = 9788770366038,
                            Classif = "Fiction",
                            Category = "Novel",
                            Price = 20.00,
                            PageCount = 352

                        },
                        new Book
                        {
                            Title = "A man Called Ove",
                            AuthFirst = "Fredrik",
                            AuthLast = "Backman",
                            Publisher = "Simon and Schuster",
                            ISBN = 9780718186616,
                            Classif = "Fiction",
                            Category = "Novel",
                            Price = 8.98,
                            PageCount = 368
                        },
                        new Book
                        {
                            Title = "Daring Greatly",
                            AuthFirst = "Brene",
                            AuthLast = "Brown",
                            Publisher = "Penguin Books",
                            ISBN = 9785768087734,
                            Classif = "Non-Fiction",
                            Category = "Self-Help",
                            PageCount = 322
                        }
                    ) ;

                context.SaveChanges();
            }
        }
        

    }
}
