using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public int BookId { get; set; }
        public List<Genre> Genres { get; set; }

    }
}
