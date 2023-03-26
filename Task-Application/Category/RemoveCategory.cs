using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Domain.Models;

namespace Task_Application.Category
{
    public class RemoveCategory
    { public  static Boolean DeleteCategory (int Id)
        {
            try
            {
                TaskDbContext db = new TaskDbContext();
                var item = db.Category.Where(c => c.Id == Id).FirstOrDefault();
                db.Category.Remove(item);
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
