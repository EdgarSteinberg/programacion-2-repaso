namespace clase_08.clases;

public class Acme
{
    private List<Micro> _micros;
    public List<Micro> Micros
    {
        get { return _micros; }
        set { _micros = value; }
    }
    public Acme()
    {
        _micros = new List<Micro>();
    }
    public void AgregarMicro(Micro micro)
    {
        _micros.Add(micro);
    }
}