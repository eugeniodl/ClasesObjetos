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

        public void EscribirMensaje()
        {
            Anidada a = new Anidada();
            a.EscribirMensaje();
        }
    }
}