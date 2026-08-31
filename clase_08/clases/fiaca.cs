namespace clase_08.clases;


public class Fiaca : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        return micro.HayAsientos() > 0;
    }

}