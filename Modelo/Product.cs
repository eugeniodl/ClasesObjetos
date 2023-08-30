using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Product
    {
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Price { get; set; }
    }
}
