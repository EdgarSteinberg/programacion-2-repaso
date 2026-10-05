namespace clase_22.clases;

public class BaseSanitaria
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private int _cantidadAmbulancias;
    public int CantidadAmbulancias
    {
        get { return _cantidadAmbulancias; }
        set { _cantidadAmbulancias = value; }
    }

    private double _tiempoAsistencia;
    public double TiempoAsistencia
    {
        get { return _tiempoAsistencia; }
        set { _tiempoAsistencia = value; }
    }

    private string _direccion;
    public string Direccion
    {
        get { return _direccion; }
        set { _direccion = value; }
    }

    public BaseSanitaria(
        string nombre,
        int cantidadAmbulancias,
        double tiempoAsistencia,
        string direccion)
    {
        _nombre = nombre;
        _cantidadAmbulancias = cantidadAmbulancias;
        _tiempoAsistencia = tiempoAsistencia;
        _direccion = direccion;
    }
}