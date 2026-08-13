using System.ComponentModel;

namespace clase_04.Clases;

public class Docente : Persona
{
    private string _materia;
    public string Materia
    {
        get { return _materia; }
        set { _materia = value; }
    }
    
    private int _horas;
    public int Horas
    {
        get { return _horas; }
        set { _horas = value; }
    }
    
    public Docente(string nombre, string apellido, string email, string materia, int horas) : base(nombre,apellido, email)
    {
        _materia = materia;
        _horas = horas;
    }

    public override string Saludar()
    {
        return $"Hola soy el profesor {Nombre} {Apellido} dicto la materia: {Materia} con {Horas}hs semanales";
    }
}