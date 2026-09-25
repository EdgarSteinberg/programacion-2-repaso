namespace clase_18_patrones.composite.clases;

public class Carpeta : Elemento
{   
    private List<Elemento> _elementos;
    public List<Elemento> Elementos
    {
        get { return _elementos; }
        set { _elementos = value; }
    }
    

    public Carpeta(string nombre, int tamano) : base(nombre, tamano)
    {
        _elementos = new List<Elemento>();
    }


    public void Agregar(Elemento elemento)
    {
        this._elementos.Add(elemento);
    }

    public void Remover(Elemento elemento)
    {
        this._elementos.Remove(elemento);
    }

    public override int DevolverTamano()
    {
        int tamanoTotal = 0;

        foreach(Elemento elemento in _elementos)
        {
            tamanoTotal += elemento.DevolverTamano();
        }

        return tamanoTotal  + this.Tamano;
    }
}