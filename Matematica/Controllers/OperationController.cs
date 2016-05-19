using Matematica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Matematica.Controllers
{
    public class OperationController : ApiController
    {

        public HttpResponseMessage Get(double v1, double v2, string op)
        {
            Operation operation = new Operation(v1,v2,op);
            operation.operate();
            var res = Request.CreateResponse<Operation>(System.Net.HttpStatusCode.Created, operation);
            return res;
        }

    }
}
