using System;
using System.ComponentModel.DataAnnotations;

namespace Bookshelf.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
    }
}
