namespace Clase_05.clases;

public class BonoPresentismoA : BonoPresentismo
{
    public override double CalcularPresentismo(Empleado empleado)
    {
        if (empleado.Inasistencias == 0)
        {
            return 1000;
        }else if(empleado.Inasistencias == 1)
        {
            return 450;
        }

        return 0;
    }
}