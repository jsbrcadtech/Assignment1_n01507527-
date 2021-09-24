using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApplication.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method returns one string when receiving a GET request 
        /// <example>GET api/square</example>
        ///</summary>
        /// <returns> { "square" }</returns>
        public IEnumerable<string> GET()
        {
            return new string[] { "Square" };
        }

        /// <summary>
        /// This method returns the square of the interger input {id} when receiving a GET request
        /// <example>GET api/squre/{id}</example>
        /// </summary>
        /// <returns>{ id*id }</returns>
        public IEnumerable<int> GET(int id)
        {
            return new int[] { id * id };
        }

    }
}
