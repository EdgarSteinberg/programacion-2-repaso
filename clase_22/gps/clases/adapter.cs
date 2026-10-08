namespace clase_22.gps.clases;

public class Adapter : IAdapter
{
    private SistemaViejo _sistemaViejo;

    public Adapter(SistemaViejo sistemaViejo)
    {
        _sistemaViejo = sistemaViejo;
    }

    public string NuevaVersion()
    {
        string coordenadasViejas = _sistemaViejo.Coordenadas();

        return TransformarCoordenadas(coordenadasViejas);
    }

    private string TransformarCoordenadas(string coordenadasViejas)
    {
        string coordenadasUTM = "UTM - " + coordenadasViejas;

        return coordenadasUTM;
    }
}