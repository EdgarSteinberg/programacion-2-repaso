namespace clase_22.chainResponsability.clases;

public class Empleado : IEmpleadoAprobador
{
    private IEmpleadoAprobador _siguienteAprobador;
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _apellido;
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    private double _montoMaximoAprobacion = 200;

    public void ElegirSiguienteAprobador(IEmpleadoAprobador siguienteAprobador)
    {
        _siguienteAprobador = siguienteAprobador;
    }

    public void AprobarCompra(double monto)
    {
        if (monto < _montoMaximoAprobacion)
        {
            Console.WriteLine("Compra aprobada por empleado " + Nombre + " " + Apellido);
        }
        else
        {
            _siguienteAprobador.AprobarCompra(monto);
        }
       
    }

    public IEmpleadoAprobador siguienteAprobador()
    {
        return _siguienteAprobador;
    }

    public Empleado(string nombre , string apellido)
    {
        _nombre = nombre;
        _apellido = apellido;
    }
}

