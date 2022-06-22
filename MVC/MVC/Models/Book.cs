using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public List<Book> Books { get; set; }
        public string AutorName { get; set; }
    }
}
