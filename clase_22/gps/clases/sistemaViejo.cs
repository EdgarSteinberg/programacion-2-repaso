namespace clase_22.gps.clases;

public class SistemaViejo
{
    private string _coordenadasLatitudLongitud;

    public string CoordenadasLatitudLongitud
    {
        get { return _coordenadasLatitudLongitud; }
        set { _coordenadasLatitudLongitud = value; }
    }

    public SistemaViejo()
    {
        _coordenadasLatitudLongitud = "Longitud y Latitud";
    }

     

    public string Coordenadas()
    {
        return _coordenadasLatitudLongitud;
    }
}