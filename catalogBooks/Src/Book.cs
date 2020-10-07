using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogBooks.Src
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public Specifications specifications { get; set; }
    }
}
