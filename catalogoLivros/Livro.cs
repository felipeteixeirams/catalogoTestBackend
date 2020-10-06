using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogoLivros
{
    public class Livro
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        
        public class Specifications
        {
            public string OriginallyPublished { get; }
            public string Author { get; }
            public int PageCount { get; }
            public string[] Illustrator { get; }
            public string[] Genres { get; }
        }
    }
}
