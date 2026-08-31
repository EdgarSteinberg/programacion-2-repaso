namespace clase_08.clases;


public class Micro
{
    private List<Empleado> _empleados;
    public List<Empleado> Empleados
    {
        get { return _empleados; }
        set { _empleados = value; }
    }

    private int _parados;
    public int Parados
    {
        get { return _parados; }
        set { _parados = value; }
    }


    private int _sentados;
    public int Sentados
    {
        get { return _sentados; }
        set { _sentados = value; }
    }

    private double _volumen;
    public double Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }

    public bool HayLugares()
    {
        return Sentados + Parados > _empleados.Count;

    }

    public int HayAsientos()
    {
        return Sentados - _empleados.Count;
    }

    public void PuedeSubir(Empleado empleado)
    {
        
        if (this.HayLugares() && empleado.AceptaSubir(this))
        {
            if (this.HayAsientos())
            {
            _empleados.Add(empleado);

            }
            else
            {
                _empleados.Add(empleado);
            }
        }
        else
        {
            throw new Exception("El empleado no puede subir");
        }
    }


    public void PrimeroEnSubir(Micro micro)
    {
        return micro.Empleados[0];
    }

    public void PuedeBajar(Micro micro)
    {
        if (micro.Empleados == null)
        {
            return $"El micro esta vacio";
        }
        else if{
            return $'Puede bajar';
        }
    }
}

