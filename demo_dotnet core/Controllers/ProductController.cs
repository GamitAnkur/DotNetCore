using demo_dotnet_core.Models;
using demo_dotnet_core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace demo_dotnet_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _productRepository1;

        public ProductController(IProductRepository productRepository, IProductRepository productRepository1)
        {
            _productRepository = productRepository;
            _productRepository1 = productRepository1;
           
        }

        public static List<ProductModel> electronic = new List<ProductModel>();


        /* [HttpPost("")]

         public IActionResult AddProduct([FromBody] ProductModel product)
         {
             _productRepository.AddProduct(product);   // Adding in first reference and 

             var products = _productRepository1.GetProducts(); // showing second reference 

             return Ok(products);

         }*/




        [HttpGet("")]


        public IActionResult GetProduct2()
        {
            return Ok("Hello");
        }


        [Route("productall")]
        public IActionResult GetProduct()
        {
           /* if (id == 0)
            {
                return NotFound();
            }*/

            return Ok(new List<ProductModel>()
            {
                new ProductModel() { Id = 1 , Name ="Ankur" },
                new ProductModel() { Id = 2 , Name ="Gamit" }

            });
        }

        [Route("redirect")]
        public IActionResult redirect()
        {

            //return Ok("Hello");
            return LocalRedirectPermanent("~/api/Product/productall") ;
        }






        /*-- create -- */

        /*[Route("id:int")]
         public IActionResult GetProductId(int id)
         {
             *//* var name =_productRepository.GetProductName();
              return Ok(name);*//*
             if (id == 0)
             {
                 return BadRequest();

             }

             return Ok(electronic.FirstOrDefault(x => x.Id == id));
         }

         [HttpPost("")]
         public IActionResult GetProductall(ProductModel product)
         {

             electronic.Add(product);

             return CreatedAtAction("GetProductId", new {id = product.Id},product);  


         }*/

    }
}
