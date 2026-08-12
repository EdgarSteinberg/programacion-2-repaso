
/* Persona objPersona = new Persona("Edgar", "Steinberg");
Console.WriteLine(objPersona.Presentarse());
 */
Visitante objVisitante = new Visitante("Estrella", "Steinberg", 35126802);
Console.WriteLine(objVisitante.Presentarse());

Guardian objGuardia = new Guardian("Btn", "Blue");
Console.WriteLine(objGuardia.Presentarse());
Console.WriteLine(objGuardia.ControlDocumento(objVisitante));

public abstract class Persona
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _apellido;

    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public Persona(string nombre, string apellido)
    {
        _nombre = nombre;
        _apellido = apellido;
    }

    public abstract string Presentarse();

}

public class Visitante : Persona
{
    private int _dni;
    public int Dni
    {
        get { return _dni; }
        set { _dni = value; }
    }
    
    public Visitante(string nombre, string apellido, int dni) : base(nombre, apellido)
    {
        Dni = dni;
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} {Apellido} y soy visitante.";
    }
}

public class Guardian : Persona
{
    public Guardian(string nombre, string apellido) : base(nombre, apellido)
    {

    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} {Apellido} y soy el guardian.";
    }

    public string ControlDocumento(Visitante visitante)
    {
        return $"Adelante {visitante.Nombre} {visitante.Apellido} El documento es : {visitante.Dni}";
    }
}