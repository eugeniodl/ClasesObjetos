using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Customer
    {
        [Required(ErrorMessage = "Name is Compulsory")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
    }
}
