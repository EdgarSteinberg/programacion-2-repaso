namespace clase_16.sueldos.clases1;

public class BonoResultado()
{
    public double CalcularBonoResultado(Empleado empleado)
    {
        if (empleado.ObjetivoCumplido == 100)
        {
            return empleado.SueldoNeto * 0.10;
        }
        else if (empleado.ObjetivoCumplido == 80)
        {
            return 800;
        }
        return 0;

    }
}