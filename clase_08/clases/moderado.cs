namespace clase_08.clases;


public class Moderado : Empleado
{
    private int _minimoLugares;
    public int MinimoLugares
    {
        get { return _minimoLugares; }
        set { _minimoLugares = value; }
    }
    
    public override bool AceptaSubir(Micro micro)
    {
        if(micro.HayLugares() >= MinimoLugares)
        {
            return true;
        }
    }
}