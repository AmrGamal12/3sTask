using Azure;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Domain.Models;
using Task.pagination;


namespace Task_Application.Mapper.ProductMapper
{
    public class ProductToProductDto
    {
        public static ProductsDtoResponse Map (List<Products> response)
        {
            
          
            var listResult = new List<ProductDtoResponse>();    
            var finalresult = new ProductsDtoResponse();
            foreach (var item in response)
            {


                var result = new ProductDtoResponse();
               result.Price = item.Price;
                result.Name= item.Name;
                result.Availablequantity= item.Availablequantity;
                result.briefdescription= item.briefdescription;
                result.Image= item.Image;
                result.Quantitylimit= item.Quantitylimit;
                result.CategoryId= item.CategoryId; 

                listResult.Add(result);

            }

            finalresult.Items= listResult;
         


            return finalresult;  
        }
    }
}
