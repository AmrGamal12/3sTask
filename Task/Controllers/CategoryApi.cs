using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Application.Category;
using Task_Application.Dto;
using Task_Application.Product;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApi : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategorys()
        {
            var result = ShowCategory.GetCategory();
            return Ok(result);
        }
        [HttpPost]
        public Boolean AddCategoryss([FromForm] CategoryDto request)
        {

            var result = AddCategory.AddCategorys(request);
            return result;
        }
        [HttpDelete]
        public Boolean DeleteCategory([FromBody] int Id)
        {
            var result = RemoveCategory.DeleteCategory(Id);
            return result;
        }
        [HttpPut]
        public Boolean UpdateeCategoryss([FromQuery] int Id, CategoryDto request)
        {
            var result = UpdateCategory.UpdateCategorys(Id,request);
            return result;
        }
    }
}
