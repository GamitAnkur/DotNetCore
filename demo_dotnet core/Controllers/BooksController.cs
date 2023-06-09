using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo_dotnet_core.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int}")]

        public string getBooks(int id)
        {
            return "Books id : " + id;
        }

        [Route("{name}")]

        public string getBookName(string name) {


            return "Book name : " + name;
        
        }
    }
}
