using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Task_Domain.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Please enter the Availablequantity")]
        public int? Availablequantity { get; set; }

        [Required(ErrorMessage = "Please enter the Quantitylimit")]
        public int? Quantitylimit { get; set; }

        //[Required(ErrorMessage = "Please enter Image for product")]
        public byte[]? Image { get; set; }

        [Required(ErrorMessage = "Please enter the briefdescription")]
        public string briefdescription { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Categorys Categorys { get; set; }

    }
}
