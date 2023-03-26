using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Domain.Models;

namespace Task_Application.Product
{
    public class RemoveProduct
    {
        public static Boolean RemoveProducts(int Id)
        {
            try
            {

                TaskDbContext db = new TaskDbContext();
                var item = db.Product.Where(x => x.Id == Id).FirstOrDefault();
                db.Product.Remove(item);
                db.SaveChanges();
                return true ;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
