using System.ComponentModel.DataAnnotations;

// Step 1 create object
Modelo.Customer obj = new();
obj.FirstName = "RENE DE LOS SANTOS";

// Step 2
var context = new ValidationContext(obj, null, null);

// Step 3
bool IsValid = Validator.TryValidateObject(obj, context, null, true);
Console.WriteLine(IsValid);

/*************************************************************/

Modelo.Product objProduct = new();
objProduct.Name = "";
objProduct.Description = "";
objProduct.Price = 20;

// Step 2
var contextP = new ValidationContext(objProduct, null, null);

// Step 3
var result = new List<ValidationResult>();
bool IsValidP = Validator.TryValidateObject(objProduct, contextP, result, true);
Console.WriteLine(IsValidP);
foreach(var p in result)
{
    Console.WriteLine(p.ErrorMessage);
}