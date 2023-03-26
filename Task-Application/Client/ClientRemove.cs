using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Domain.Models;

namespace Task_Application.Client
{
    public class ClientRemove
    {
        public static Boolean RemoveClient(int Id)
        {
            try
            {

                TaskDbContext db = new TaskDbContext();
                var item = db.Client.Where(x => x.Id == Id).FirstOrDefault();
                db.Client.Remove(item);
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
