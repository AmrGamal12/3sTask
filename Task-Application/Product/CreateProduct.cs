using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Application.Mapper;
using Task_Domain.Models;

namespace Task_Application.Product
{
    public class CreateProduct
    {
        public static Boolean AddProduct(ProductDto request)
        {
            try
            {
                var item = ProductDtoToProduct.Map(request);
                TaskDbContext db = new TaskDbContext();
                db.Product.Add(item);
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
