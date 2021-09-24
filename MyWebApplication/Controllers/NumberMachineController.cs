using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApplication.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns one string when receiving a post request 
        /// <example>GET api/NumberMachine</example>
        ///</summary>
        /// <returns> { "Number Machine" } </returns>
        public IEnumerable<string> GET()
        {
            return new string[] { "Number Machine" };
        }

        /// <summary>
        /// This method  has an input {id}, and applies four mathematical operations to it when receiving a GET request
        /// <example>GET api/NumberMachine/{id}
        /// </summary>
        /// <returns> { id+id, id-id, id*id, id/id } </returns>
        public IEnumerable<int> GET(int id)
        {
            return new int[] { id + id, id - id, id * id, id / id };
        }

    }
}
