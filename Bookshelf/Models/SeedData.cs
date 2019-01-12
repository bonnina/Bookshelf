using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Bookshelf.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookshelfContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookshelfContext>>()))
            {
                // Look for any books
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Pollyannna",
                        PublishDate = DateTime.Parse("1979-5-10"),
                        Genre = "Fiction",
                        Author = "Eleanor Potter",
                        Rating = "R"
                    },

                    new Book
                    {
                        Title = "The Complete Reference ",
                        PublishDate = DateTime.Parse("2010-7-07"),
                        Genre = "Education",
                        Author = "Herbert Shildt",
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
