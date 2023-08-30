namespace Modelo
{
    public class Contenedora
    {
        class Anidada
        {
            public void EscribirMensaje()
            {
                Console.WriteLine("Anidada.EscribirMensaje");
            }
        }
        public void AnidadaEscribirMensaje()
        {
            Anidada anidada = new Anidada();
            anidada.EscribirMensaje();
        }
    }
}