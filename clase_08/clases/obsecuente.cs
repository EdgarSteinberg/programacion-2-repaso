namespace clase_08.clases;


public class Obsecuente : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        return this.Jefe.AceptaSubir();
    }
}