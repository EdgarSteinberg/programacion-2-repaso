namespace Clase_05.clases;

public class Empresa
{
    private List<Empleado> _empleados;

    public List<Empleado> Empleados
    {
        get { return _empleados; }
        set { _empleados = value; }
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        _empleados.Add(empleado);
    }

    public void EliminarEmpleado(Empleado empleado)
    {
        _empleados.Remove(empleado);
    }

    public double CalcularSueldoEmpleado(Empleado empleado)
    {
        return empleado.CalcularSueldo();
    }
}