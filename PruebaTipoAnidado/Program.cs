Modelo.Contenedora contenedora = new();
contenedora.AnidadaEscribirMensaje();

Modelo.Estaciones estaciones = new();
Console.WriteLine(estaciones.Invierno.MesInicio);

Console.WriteLine("Inicio de cada estación:");
foreach (Modelo.Estaciones.Estacion estacion in estaciones)
{
    Console.WriteLine(estacion.MesInicio);
}
