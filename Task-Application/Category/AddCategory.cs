using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Application.Mapper;
using Task_Application.Mapper.CategoryMapper;
using Task_Domain.Models;

namespace Task_Application.Category
{
    public class AddCategory
    {
        public static Boolean AddCategorys(CategoryDto request)
        {
            try
            {
                var item = CategoryDToToCategory.Map(request);
                TaskDbContext db = new TaskDbContext();
                db.Category.Add(item);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
