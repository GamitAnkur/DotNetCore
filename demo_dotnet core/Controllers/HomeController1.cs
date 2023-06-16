using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_dotnet_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController1 : ControllerBase
    {

        [Route("get-all")]
        public string get()
        {
            return "Hello World Values";
        }

    }
}
