using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title{ get; set; }

        public string ISBN { get; set; }

        public int Pages { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
