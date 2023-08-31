int estatusOperacion = 5;

if(estatusOperacion == (int)EstatusOperacion.Exitoso)
{
    // ...
}
else if(estatusOperacion == 2)
{
    // ...
}
else if (estatusOperacion == 5)
{
    // ...
}

public enum EstatusOperacion
{
    Exitoso = 1,
    ClienteNoEncontrado = 2,
    ErrorDeSistema = 5
}
