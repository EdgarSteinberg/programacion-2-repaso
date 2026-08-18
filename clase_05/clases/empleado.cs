namespace Clase_05.clases;

public abstract class Empleado
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private double _sueldoNeto;
    public double SueldoNeto
    {
        get { return _sueldoNeto; }
        set { _sueldoNeto = value; }
    }

    private int _inasistencias;
    public int Inasistencias
    {
        get { return _inasistencias; }
        set { _inasistencias = value; }
    }

    private int _objetivo;
    public int Objetivo
    {
        get { return _objetivo; }
        set { _objetivo = value; }
    }

    private BonoResultado _bonoResultado;
    public BonoResultado BonoResultado
    {
        get { return _bonoResultado; }
        set { _bonoResultado = value; }
    }

    private BonoPresentismo _bonoPresentismo;
    public BonoPresentismo BonoPresentismo
    {
        get { return _bonoPresentismo; }
        set { _bonoPresentismo = value; }
    }


    public double CalcularSueldo()
    {
        return SueldoNeto
             + BonoPresentismo.CalcularPresentismo(this)
             + BonoResultado.CalcularBonoObjetivo(this);
    }

    public Empleado(string nombre, double sueldoNeto, int inasisencias, int objetivo, BonoResultado bonoResultado, BonoPresentismo bonoPresentismo)
    {
        _nombre = nombre;
        _sueldoNeto = sueldoNeto;
        _inasistencias = inasisencias;
        _objetivo = objetivo;
        _bonoResultado = bonoResultado;
        _bonoPresentismo = bonoPresentismo;
    }
}