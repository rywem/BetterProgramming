using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApp.Controllers
{
    public class MyApiController : ApiController
    {

        [HttpPost]
        [Route("PostFirstThing/{a}/{b}")]
        public IHttpActionResult PostFirstThing([FromUri]int a, [FromUri]int b = 1)
        {
            return Ok(new Response() { X = a, Y = b });
        }

        
        [HttpPost]
        [Route("PostRequest")]
        public IHttpActionResult PostRequest([FromBody]MyRequest request)
        {
            /* Request example: 
             * Header(s):
             *      Content-Type: application/json
             * Body: 
             *      {  "A" : 2, "B" : 3 }
             */
            return Ok(new Response()
            {
                X = request.A,
                Y = request.B
            });
        }

        public class Response
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public class MyRequest
        {
            public int A { get; set; }
            public int B { get; set; }
        }
    }
}
