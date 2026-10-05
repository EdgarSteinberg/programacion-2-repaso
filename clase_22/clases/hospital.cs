namespace clase_22.clases;

public class Hospital : BaseSanitaria
{
    private int _personal;
    public int Personal
    {
        get { return _personal; }
        set { _personal = value; }
    }

    public Hospital(
        string nombre,
        int cantidadAmbulancias,
        double tiempoAsistencia,
        string direccion,
        int personal)
        : base(nombre, cantidadAmbulancias, tiempoAsistencia, direccion)
    {
        _personal = personal;
    }
}