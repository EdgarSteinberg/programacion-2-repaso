namespace clase_04.Clases;

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

    private string _email;
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public Persona(string nombre, string apellido, string email)
    {
        _nombre = nombre;
        _apellido = apellido;
        _email = email;
    }

    public abstract string Saludar();
}