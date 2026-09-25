namespace clase_18_patrones.composite.clases;

public abstract class Elemento
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    private int _tamano;
    public int Tamano
    {
        get { return _tamano; }
        set { _tamano = value; }
    }
    
    public Elemento(string nombre, int tamano)
    {
        this.Nombre = nombre;
        this.Tamano = tamano;
    }

    public abstract int DevolverTamano();
}