
namespace clase_08.clases;

public class Micro
{
    private List<Empleado> _empleados = new List<Empleado>();

    public List<Empleado> Empleados
    {
        get { return _empleados; }
        set { _empleados = value; }
    }

    // Cantidad de lugares para pasajeros parados
    private int _parados;

    public int Parados
    {
        get { return _parados; }
        set { _parados = value; }
    }

    // Cantidad de lugares para pasajeros sentados
    private int _sentados;

    public int Sentados
    {
        get { return _sentados; }
        set { _sentados = value; }
    }

    // Cantidad de pasajeros que actualmente están sentados
    private int _cantidadSentados;

    public int CantidadSentados
    {
        get { return _cantidadSentados; }
        set { _cantidadSentados = value; }
    }

    private double _volumen;

    public double Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }


    // Indica si queda algún lugar libre en el micro.
    public bool HayLugares()
    {
        return Sentados + Parados > _empleados.Count;
    }


    // Devuelve la cantidad de asientos libres.
    public int HayAsientos()
    {
        return Sentados - CantidadSentados;
    }


    // Permite subir un empleado si hay lugar
    // y el empleado acepta subir.
    public void PuedeSubir(Empleado empleado)
    {
        if (HayLugares() && empleado.AceptaSubir(this))
        {
            _empleados.Add(empleado);

            // Si todavía quedan asientos,
            // el empleado ocupa uno.
            if (HayAsientos() > 0)
            {
                CantidadSentados++;
            }
        }
        else
        {
            throw new Exception("El empleado no puede subir");
        }
    }


    // Devuelve el primer empleado que subió.
    // Si el micro está vacío, devuelve null.
    public Empleado PrimeroEnSubir()
    {
        if (_empleados.Count == 0)
        {
            return null;
        }

        return _empleados[0];
    }

    public void PuedeBajar(Empleado empleado)
    {
        if (_empleados.Count == 0)
        {
            throw new Exception("El micro esta vacio");
        }
        _empleados.Remove(empleado);
    }
}
