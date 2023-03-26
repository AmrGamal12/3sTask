using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_Application.Dto
{

    public class ProductsDtoResponse
    {
        public List<ProductDtoResponse> Items { get; set; }
        public int totalcount { get; set; }
        public int totalpages { get; set; }

    }
    public class ProductDtoResponse
    {
        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Please enter the Availablequantity")]
        public int? Availablequantity { get; set; }

        [Required(ErrorMessage = "Please enter the Quantitylimit")]
        public int? Quantitylimit { get; set; }

        [Required(ErrorMessage = "Please enter Image for product")]
        public byte[]? Image { get; set; }

        [Required(ErrorMessage = "Please enter the briefdescription")]
        public string briefdescription { get; set; }
        public int CategoryId { get; set; }
    }
}
