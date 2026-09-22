namespace clase_16.sueldos.clases1;


public class BonoPresentismoA : BonoPresentismo
{
    public double CalcularBonoPresentismo(Empleado empleado)
    {
        if (empleado.Presentismo == 0)
        {
            return 1000;
        }
        else if (empleado.Presentismo == 1)
        {
            return 450;
        }

        return 0;

    }
}