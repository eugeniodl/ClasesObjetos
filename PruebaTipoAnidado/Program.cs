Modelo.Contenedora contenedora = new();
contenedora.EscribirMensaje();

Modelo.Estaciones estaciones = new();
Console.WriteLine(estaciones.Verano.MesInicio);

Console.WriteLine("Inicio de cada estación");
foreach (Modelo.Estaciones.Estacion estacion in estaciones)
{
    Console.WriteLine(estacion.MesInicio);
}