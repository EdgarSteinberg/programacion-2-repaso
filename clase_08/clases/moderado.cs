namespace clase_08.clases;

public class Moderado : Empleado
{
    private int _minimoLugares;
    public int MinimoLugares
    {
        get { return _minimoLugares; }
        set { _minimoLugares = value; }
    }
    
    public Moderado(int minimoLugares)
    {
        _minimoLugares = minimoLugares;
    }
    public override bool AceptaSubir(Micro micro)
    {
        if(micro.HayAsientos() >= MinimoLugares)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}