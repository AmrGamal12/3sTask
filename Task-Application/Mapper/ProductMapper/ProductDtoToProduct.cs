using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Domain.Models;

namespace Task_Application.Mapper
{
    public class ProductDtoToProduct
    {
        public static Products Map(ProductDto request)
        {     using var dataStream = new MemoryStream();
            request.Image.CopyToAsync(dataStream);  
        
            var result = new Products();    
            result.Price = request.Price;
            result.Name= request.Name;  
            result.Availablequantity= request.Availablequantity;    
            result.briefdescription= request.briefdescription;  
            result.Image= dataStream.ToArray();
            result.Quantitylimit= request.Quantitylimit;
            result.CategoryId= request.CategoryId;  

            return result;
        }
    }
}
