using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Resources;

namespace Task_Application.Dto
{

    

    public class ProductDto

    {
        [Required(ErrorMessageResourceName = "Name", ErrorMessageResourceType = typeof(strings))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceName = "Price", ErrorMessageResourceType = typeof(strings))]
        public double? Price { get; set; }
        [Required(ErrorMessageResourceName = "Availablequantity", ErrorMessageResourceType = typeof(strings))]
        public int? Availablequantity { get; set; }
        [Required(ErrorMessageResourceName = "Quantitylimit", ErrorMessageResourceType = typeof(strings))]
        public int? Quantitylimit { get; set; }
        [Required(ErrorMessageResourceName = "Image", ErrorMessageResourceType = typeof(strings))]
        public IFormFile? Image { get; set; }
        [Required(ErrorMessageResourceName = "briefdescription", ErrorMessageResourceType = typeof(strings))]
        public string briefdescription { get; set; }
        public int CategoryId { get; set; }

    }
}
