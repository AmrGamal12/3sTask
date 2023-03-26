using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Domain.Models;

namespace Task_Application.Mapper.CategoryMapper
{
    public class CategoryToCategoryDto
    {
        public static List<CategoryDto> Map (List<Categorys> response)
        {
            var listResult = new List<CategoryDto>();
            foreach (var item in response)
            {
                var result = new CategoryDto();
              
                result.Name = item.Name;
                result.parentCategorysId=item.parentCategorysId;

                listResult.Add(result);

            }
            return listResult;
        }
    }
}
