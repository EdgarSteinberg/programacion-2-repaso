namespace clase_22.chainResponsability.clases;

public class Jefe : IEmpleadoAprobador
{
    private IEmpleadoAprobador _siguienteAprobador;
    private double _montoMaximoAprobacion = 1000;
    public void ElegirSiguienteAprobador(IEmpleadoAprobador siguienteAprobador)
    {
        _siguienteAprobador = siguienteAprobador;
    }

    public void AprobarCompra(double monto)
    {
        if (monto < _montoMaximoAprobacion)
        {
            Console.WriteLine("Compra aprobada por jefe" );
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
}

