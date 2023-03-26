using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Application.Mapper.CategoryMapper;
using Task_Domain.Models;

namespace Task_Application.Category
{
    public class ShowCategory
    {
        public static List<CategoryDto> GetCategory()
        {
            try
            { TaskDbContext db = new TaskDbContext();
                var item = db.Category.ToList();
                var result = CategoryToCategoryDto.Map(item);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
