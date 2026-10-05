namespace clase_22.clases;

public class Uap : BaseSanitaria
{
    private int _personalAtencionMedica;
    public int PersonalAtencionMedica
    {
        get { return _personalAtencionMedica; }
        set { _personalAtencionMedica = value; }
    }

    public Uap(
        string nombre,
        int cantidadAmbulancias,
        double tiempoAsistencia,
        string direccion,
        int personalAtencionMedica)
        : base(nombre, cantidadAmbulancias, tiempoAsistencia, direccion)
    {
        _personalAtencionMedica = personalAtencionMedica;
    }
}