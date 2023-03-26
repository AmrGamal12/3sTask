using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Domain.Models;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using Task_Application.Mapper.ProductMapper;
using Microsoft.EntityFrameworkCore;

namespace Task_Application.Product
{
    public class search
    
    {
         public static ProductsDtoResponse GetProductById (int id,int pagenumber,int pagesize)
        {
            try
            {
                TaskDbContext db = new TaskDbContext();
               
                var items = db.Product.FromSql($"exec GetProduct {id},{pagenumber},{pagesize} ").ToList();
               
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
