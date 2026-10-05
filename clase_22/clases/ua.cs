namespace clase_22.clases;

public class Ua : BaseSanitaria
{
    private List<BaseSanitaria> _baseSanitarias;

    public List<BaseSanitaria> BaseSanitarias
    {
        get { return _baseSanitarias; }
        set { _baseSanitarias = value; }
    }

    public Ua(
        string nombre,
        string direccion)
        : base(nombre, 0, 0, direccion)
    {
        _baseSanitarias = new List<BaseSanitaria>();
    }

    public void AgregarBaseSanitaria(BaseSanitaria baseSanitaria)
    {
        _baseSanitarias.Add(baseSanitaria);
    }

    public void EliminarBaseSanitaria(BaseSanitaria baseSanitaria)
    {
        _baseSanitarias.Remove(baseSanitaria);
    }

    public int AmbulanciasDisponibles()
    {
        int ambulancias = 0;

        foreach (var baseSanitaria in _baseSanitarias)
        {
            ambulancias += baseSanitaria.CantidadAmbulancias;
        }

        return ambulancias;
    }

    public double PromedioTiempoAsistencia()
    {
        if (_baseSanitarias.Count == 0)
        {
            return 0;
        }

        double tiempo = 0;

        foreach (var baseSanitaria in _baseSanitarias)
        {
            tiempo += baseSanitaria.TiempoAsistencia;
        }

        return tiempo / _baseSanitarias.Count;
    }
}