using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApplication.Controllers
{
    public class TestController : ApiController
    {
         //purpose of the controller -> Listen for HTTP requests  
        // INPUT: nothing 
        // OUTPUT : 5
        //*** Use localhost:e.g.1231/api/Test to access the OUTPUT 
        
        public int Get()
        {
            return 5;
        }

    }
}
