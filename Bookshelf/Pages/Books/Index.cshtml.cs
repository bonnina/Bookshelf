using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bookshelf.Models;

namespace Bookshelf.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Bookshelf.Models.BookshelfContext _context;

        public IndexModel(Bookshelf.Models.BookshelfContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
