using System.ComponentModel.DataAnnotations;

// Step 1 create object
Modelo.Customer cliente = new();
cliente.Name = "ANTHONY DE LOS SANTOS";

// Step 2 
var context = new ValidationContext(cliente, null, null);

// Step 3
var result = new List<ValidationResult>();
bool isValid = Validator.TryValidateObject(cliente, context, 
    result, true);
Console.WriteLine(isValid);

foreach(var validationResult in result)
{
    Console.WriteLine(validationResult.ErrorMessage);
}