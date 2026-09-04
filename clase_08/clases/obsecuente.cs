namespace clase_08.clases;


public class Obsecuente : Empleado
{
    private Empleado _jefe;
    public Empleado Jefe
    {
        get { return _jefe; }
        set { _jefe = value; }
    }
    public Obsecuente(Empleado jefe)
    {
        _jefe = jefe;
    }
    public override bool AceptaSubir(Micro micro)
    {
        return this._jefe.AceptaSubir(micro);
    }
}