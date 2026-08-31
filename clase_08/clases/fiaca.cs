namespace clase_08.clases;


public class Fiaca : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.HayAsientos())
        {
            return true;
        }
    }
}