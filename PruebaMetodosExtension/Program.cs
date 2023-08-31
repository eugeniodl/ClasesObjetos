// Este programa muestra el uso de métodos de
// extensión
using Modelo;

int numero = 55;
bool par = numero.EsPar(); // Aquí encontramos
                           // la extensión

Console.WriteLine("{0} es {1}", numero, par);

// Extensión del double
double valor = 55.18;

Console.WriteLine(valor.Duplica());