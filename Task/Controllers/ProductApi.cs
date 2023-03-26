using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.pagination;
using Task_Application.Dto;
using Task_Application.Mapper.ProductMapper;
using Task_Application.Product;
using Task_Domain.Models;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApi : ControllerBase
    {
        [HttpGet]
        public IActionResult getProducts([FromQuery] Paginationfilter filter)
        {
            TaskDbContext db = new TaskDbContext();
            var validFilter = new Paginationfilter(filter.PageNumber, filter.PageSize);
            var skip = (validFilter.PageNumber - 1) * validFilter.PageSize;
            var take = validFilter.PageSize;
            var pagedData = db.Product.Skip(skip).Take(take).ToList();
            var totalRecords = db.Product.Count();
            var totalpages = totalRecords / filter.PageSize;
            var result = ProductToProductDto.Map(pagedData);
            result.totalcount = totalRecords;
            result.totalpages= totalpages;

            return Ok(result);
           
        }

        [HttpGet("{id}")]
            public IActionResult getById(int id , int pagenumber , int pagesize)
            { 
            var result = search.GetProductById(id,pagenumber,pagesize);
            return Ok (result.Items); 
            }
        
        [HttpPost]  
        public Boolean addProduct([FromForm] ProductDto request)
        {
            
            var result = CreateProduct.AddProduct(request);
            return result;
        }
        [HttpDelete]
        public Boolean DeleteProduct([FromBody] int Id)
        {
            var result = RemoveProduct.RemoveProducts(Id);
            return result;
        }
    }
}
