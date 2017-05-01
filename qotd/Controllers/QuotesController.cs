using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace qotd.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        private static IList<string> _Quotes = new List<string>
        {
            "Hi",
            "Yo"
        };
        
        private static Random _Random = new Random();

        // GET api/quotes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _Quotes;
        }

        // GET api/quotes/random
        [HttpGet("random")]
        public string Random()
        {
            // range is not inclusive of max value:
            var randomIndex = _Random.Next(0, _Quotes.Count());
            return _Quotes[randomIndex];
        }

        // POST api/quotes
        [HttpPost]
        public void Post(string quote)
        {
            _Quotes.Add(quote);
        }

        // DELETE api/quotes
        [HttpDelete]
        public void Delete(string quote)
        {
            _Quotes.Remove(quote);
        }
    }
}
