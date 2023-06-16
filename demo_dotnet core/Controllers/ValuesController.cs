using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_dotnet_core.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {

        //[Route("get")]
        // we can inter change 

        public string get()
        {
            return "Ankur";
        }

        // [Route("~/get-id")]   // we set own route without using base route
        // [Route("{id}")]   // just we need to pass dynamic value base route is already given
        //[Route("{id:min(10)}")] // min value should be 10 or more than 10

        [Route("{id:max(10)}")]  // Max value should be 10 or less
        public string getid(int id)
        {
            return "Id is :"+id;
        }

        /*-- Variable routing --*/

        //[Route("books/{id}/author/{name}")]
        [Route("{id:min(2)}/{name:minlength(5)}")]

        public string getname(string name,int id)
        {
            return "Book Id :" + id + " " + "Book name :" + name;
        }

        /*-- Query routing --*/

        //[Route("search")]
        public string search(int id, string name,string email,int mobile)
        {
            return "Book Id :" + id + " " + "Book name :" + name;
        }



    }
}
