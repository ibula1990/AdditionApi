using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AdditionApi.Controllers
{
    public class AdditionController : ApiController
    {
        // GET: Addition
        public string  GetCalk(int FirstNumber, int SecondNumber)
        {
            int c = Convert.ToInt32(FirstNumber) + Convert.ToInt32(SecondNumber);
            return (c.ToString());
        }
    }
}