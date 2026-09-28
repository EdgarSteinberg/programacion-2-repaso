namespace clase_20_clases;

public class Documento
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _contenido;
    public string Contenido
    {
        get { return _contenido; }
        set { _contenido = value; }
    }

    public Documento(string nombre, string contenido)
    {
        _nombre = nombre;
        _contenido = contenido; 
    }
}