namespace clase_08.clases;


public class Moderado : Empleado
{
    private int _lugaresLibre;
    public int LugaresLibres
    {
        get { return _lugaresLibre; }
        set { _lugaresLibre = value; }
    }
    
    public override bool AceptaSubir(Micro micro)
    {
        if(micro.HayLugar() >= LugaresLibres)
        {
            return true;
        }
    }
}