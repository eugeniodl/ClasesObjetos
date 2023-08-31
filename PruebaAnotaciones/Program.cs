using System.ComponentModel.DataAnnotations;

// Step 1 create object
Modelo.Customer obj = new();
obj.FirstName = "";

// Step 2
var context = new ValidationContext(obj, null, null);

// Step 3
var result = new List<ValidationResult>();
bool IsValid = Validator.TryValidateObject(obj, context, result, true);
Console.WriteLine(IsValid);
foreach (var item in result)
{
    Console.WriteLine(item.ErrorMessage);
}

/*************************************************************/

Modelo.Product objProduct = new();
objProduct.Name = "";
objProduct.Description = "";
objProduct.Price = 20;

// Step 2
var contextP = new ValidationContext(objProduct, null, null);

// Step 3
var resultP = new List<ValidationResult>();
bool IsValidP = Validator.TryValidateObject(objProduct, contextP, resultP, true);
Console.WriteLine(IsValidP);
foreach(var p in resultP)
{
    Console.WriteLine(p.ErrorMessage);
}