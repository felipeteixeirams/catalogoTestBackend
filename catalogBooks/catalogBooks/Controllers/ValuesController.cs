using System;
using System.IO;
using catalogBooks.Src;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace catalogBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public class ConvertJson
        {
            object booksJson = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\books.json");
            object js = DataContractJsonSerializer(typeof(List<Book>));
            object ms = new MemoryStream(Encoding.UTF8.GetBytes(js));
            object books = (List<Book>)js.ReadObject(ms);

            private static object DataContractJsonSerializer(Type type)
            {
                throw new NotImplementedException();
            }
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { books };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

    }
}
