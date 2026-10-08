namespace clase_22.gps.clases;

public class CentralMonitoreo
{
    private IAdapter _adapter;

    private List<Modulo> _modulos;

    public List<Modulo> Modulos
    {
        get { return _modulos; }
        set { _modulos = value; }
    }

    public CentralMonitoreo(IAdapter adapter)
    {
        _modulos = new List<Modulo>();
        _adapter = adapter;
    }

    public void ActualizarPosicion()
    {
        string coordenadas = _adapter.NuevaVersion();

        Console.WriteLine(coordenadas);
    }
}