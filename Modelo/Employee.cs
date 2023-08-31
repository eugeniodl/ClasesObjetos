using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Employee
    {
        private int _idNumber;
        private string _firstName;
        private string _lastName;

        // Public properties
        [Display(Name = "ID Number",
            Description = "Enter an integer between " +
            "0 and 99999.")]
        [Range(0, 99999)]
        public int IdNumber
        {
            get { return _idNumber; }
            set
            {
                Validator.ValidateProperty
                    (value,
                    new ValidationContext(this, null, null)
                    { MemberName = "IdNumber" });
                _idNumber = value;
            }
        }
        [Display(Name = "Name",
            Description = "First Name + Last Name.")]
        [Required(ErrorMessage =
            "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
            ErrorMessage =
            "Numbers and special characters are not " +
            "allowed in the name.")]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                Validator.ValidateProperty
                    (value,
                    new ValidationContext(this, null, null)
                    { MemberName = "FirstName" });
                _firstName = value;
            }
        }
        [Required(ErrorMessage =
    "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
    ErrorMessage =
    "Numbers and special characters are not " +
    "allowed in the name.")]
        [StringLength(8, MinimumLength = 3,
            ErrorMessage = 
            "Last name must be between 3 and 8 " +
            "characters long.")]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                Validator.ValidateProperty
                    (value,
                    new ValidationContext(this, null, null)
                    { MemberName = "LastName" });
                _lastName = value;
            }
        }
    }
}
