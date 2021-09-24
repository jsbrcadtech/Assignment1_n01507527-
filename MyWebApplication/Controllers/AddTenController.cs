using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApplication.Controllers
{
    public class AddTenController : ApiController
    {
            /// <summary>
            /// This method returns one string when receiving a post request 
            /// <example>GET api/addten</example>
            ///</summary>
            /// <returns> { "add ten" }</returns>
            public IEnumerable<string> GET()
            {
                return new string[] { "add ten" };
            }

            /// <summary>
            /// This method returns 10 more than the interger input {id} when receiving a GET request
            /// <example>GET api/addten/{id}
            /// </summary>
            /// <param name="id"></param>
            /// <returns>{ id+10 }</returns>
            public IEnumerable<int> GET(int id)
            {
                return new int[] { id + 10 };
            }


        }
    }
