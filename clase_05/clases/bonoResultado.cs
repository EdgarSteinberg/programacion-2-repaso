namespace Clase_05.clases;

public class BonoResultado
{
    public double CalcularBonoObjetivo(Empleado empleado)
    {
        if (empleado.Objetivo == 100)
        {
            return empleado.SueldoNeto * 10;
        }
        else if (empleado.Objetivo == 80)
        {
            return 800;
        }
        return 0;
    }
}