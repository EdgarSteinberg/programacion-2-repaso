namespace clase_22.chainResponsability.clases;
public interface IEmpleadoAprobador
{
    void ElegirSiguienteAprobador(IEmpleadoAprobador siguienteAprobador);
    
    void AprobarCompra(double monto);

    IEmpleadoAprobador siguienteAprobador();
}