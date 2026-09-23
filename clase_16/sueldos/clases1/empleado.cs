namespace clase_16.sueldos.clases1;

public class Empleado
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private BonoPresentismo _bonoPresentismo;
    public BonoPresentismo BonoPresentismo
    {
        get { return _bonoPresentismo; }
        set { _bonoPresentismo = value; }
    }

    private BonoResultado _bonoResultado;
    public BonoResultado BonoResultado
    {
        get { return _bonoResultado; }
        set { _bonoResultado = value; }
    }

    private double _sueldoNeto;
    public double SueldoNeto
    {
        get { return _sueldoNeto; }
        set { _sueldoNeto = value; }
    }

    private double _presentismo;
    public double Presentismo
    {
        get { return _presentismo; }
        set { _presentismo = value; }
    }

    private double _objetivoCumplido;
    public double ObjetivoCumplido
    {
        get { return _objetivoCumplido; }
        set { _objetivoCumplido = value; }
    }

    public Empleado(string nombre, BonoPresentismo bonoPresentismo, double sueldoNeto, double presentismo, double objetivoCumplido)
    {
        this._nombre = nombre;
        this._bonoPresentismo = bonoPresentismo;
        this._bonoResultado = new BonoResultado();
        this._sueldoNeto = sueldoNeto;
        this._presentismo = presentismo;
        this._objetivoCumplido = objetivoCumplido;
    }
    public double CalcularSueldo()
    {
        return this.SueldoNeto + BonoPresentismo.CalcularBonoPresentismo(this) + BonoResultado.CalcularBonoResultado(this);
    }


}