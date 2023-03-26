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
    public class UpdateCategory
    {
        public static Boolean UpdateCategorys(int Id, CategoryDto request)
        {
            try
            {
                TaskDbContext db = new TaskDbContext();
                var category = CategoryDToToCategory.Map(request);
                var categoryid = db.Category.Where(c => c.Id == Id).FirstOrDefault();
                categoryid.Name = category.Name;
                categoryid.parentCategorysId = category.parentCategorysId;
                db.Category.Update(categoryid);
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
