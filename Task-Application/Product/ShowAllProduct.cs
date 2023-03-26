//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Application.Mapper;
using Task_Application.Mapper.ProductMapper;
using Task_Domain.Models;

namespace Task_Application.Product
{
    public class ShowAllProduct
    {
        public static ProductsDtoResponse ShowAllProducts()
        {
            try
            {
                TaskDbContext db = new TaskDbContext();
                var items = db.Product.ToList();
               var result = ProductToProductDto.Map(items);




                return result;

            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }

        }
    }
}
