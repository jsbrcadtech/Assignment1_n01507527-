using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApplication.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!" when receiving a POST request 
        /// <example>POST api/Greeting</example>
        ///</summary>
        /// <returns> { "Hello World!" } </returns>
        public IEnumerable<string> POST()
        {
            return new string[] { "Hello World!" };
        }

        /// <summary>
        /// This method returns the string "Greeting" when receiving a GET request
        /// <example>GET api/Greeting/example>
        /// </summary>
        /// <returns> { "Greeting" } </returns>
        public IEnumerable<string> GET()
        {
            return new string[] { "Greeting" };
        }

        /// <summary>
        /// This method returns the string "Greetings to {id} people!" where id is integer value  when receiving a GET request
        /// <example>GET api/Greeting/{id}example>
        /// </summary>
        /// <returns> { "Greetings to " + id + " people!" } </returns>
        public IEnumerable<string> GET(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }
    }
}
