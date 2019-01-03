using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Models
{
    public class BookshelfContext : DbContext
    {
        public BookshelfContext (DbContextOptions<BookshelfContext> options)
            : base(options)
        {
        }

        public DbSet<Bookshelf.Models.Book> Book { get; set; }
    }
}
