using System;
using System.Collections.Generic;
using catalogBooks.Src;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catalogBooks.Controllers
{
    [Route("api/[catalog]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        public void deserialiseJson()
        {
            Catalog catalog = JsonConvert.DeserializeObject<Catalog>(@"\book.json");
        }


        // GET: api/<CatalogController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            int count = catalog.Lenght;
            return new Book { catalogBooks[] };
        }

        // GET api/<CatalogController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
