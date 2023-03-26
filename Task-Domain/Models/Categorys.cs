using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Domain.Models
{
    public class Categorys
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        public List<Products> products { get; set; }
        
        public int parentCategorysId { get; set; }
        [ForeignKey("parentCategorysId")]
        public List<Categorys> category { get; set; }
        



    }
}
