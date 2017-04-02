using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksApiTreeLineProject.Models
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public double price { get; set; }
        public bool ifebook { get; set; }
    }
}