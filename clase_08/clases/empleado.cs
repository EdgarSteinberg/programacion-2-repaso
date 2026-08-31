namespace clase_08.clases;


public abstract class Empleado
{   
    private Empleado _jefe;
    public Empleado Jefe
    {
        get { return _jefe; }
        set { _jefe = value; }
    }
    
    public abstract bool AceptaSubir(Micro micro);
    
}