using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mybooks2.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }


        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
