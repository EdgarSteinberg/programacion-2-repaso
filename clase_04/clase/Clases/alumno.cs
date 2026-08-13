namespace clase_04.Clases;

public class Alumno : Persona
{
    private string _legajo;
    public string Legajo
    {
        get { return _legajo; }
        set { _legajo = value; }
    }

    private float _promedio;
    public float Promedio
    {
        get { return _promedio; }
        set { _promedio = value; }
    }

    public Alumno(
        string nombre,
        string apellido,
        string email,
        string legajo,
        float promedio
    ) : base(nombre, apellido, email)
    {
        _legajo = legajo;
        _promedio = promedio;
    }

    public override string Saludar()
    {
        return $"Hola soy el alumno {Nombre}, {Apellido} con legajo {Legajo} y email: {Email} mi promedio es: {Promedio}";
    }

    public bool EstoyPresente()
    {
        return true;
    }
}