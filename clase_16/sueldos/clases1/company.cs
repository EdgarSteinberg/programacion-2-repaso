namespace clase_16.sueldos.clases1;

public class Company
{
    private List<Empleado> _empleados;
    public List<Empleado> Empleados
    {
        get { return _empleados; }
        set { _empleados = value; }
    }

    public Company()
    {
        _empleados = new List<Empleado>();
    }
    public void MostraEmpleados()
    {
        foreach (var empleado in _empleados)
        {
            Console.WriteLine($"{empleado.Nombre} : sueldo neto {empleado.CalcularSueldo()}");
        }
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        _empleados.Add(empleado);
    }
}