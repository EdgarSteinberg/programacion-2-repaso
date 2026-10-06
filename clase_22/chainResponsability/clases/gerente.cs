namespace clase_22.chainResponsability.clases;

public class Gerente : IEmpleadoAprobador
{
    private IEmpleadoAprobador _siguienteAprobador;
    private double _montoMaximoAprobacion = 5000;
    
    public void ElegirSiguienteAprobador(IEmpleadoAprobador siguienteAprobador)
    {
        _siguienteAprobador = siguienteAprobador;
    }

    public void AprobarCompra(double monto)
    {
        if (monto < _montoMaximoAprobacion)
        {
            Console.WriteLine("Compra aprobada por gerente" );
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

