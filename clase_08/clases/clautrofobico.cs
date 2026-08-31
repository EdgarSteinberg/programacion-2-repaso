namespace clase_08.clases;


public class Clautrofobico : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        if(micro.Volumen > 120)
        {
            return true;
        }

        return false;
    }
}