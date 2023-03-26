using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Domain.Models;

namespace Task_Application.Mapper.CategoryMapper
{
    public class CategoryDToToCategory
    {
        public static Categorys Map(CategoryDto request)
        {
            var result = new Categorys();
             
            result.Name = request.Name;
            result.parentCategorysId=request.parentCategorysId;
            return result;
        }
    }
}
