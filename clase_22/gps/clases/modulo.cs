namespace clase_22.gps.clases;

public class Modulo
{
    private string _tecnologia;

    public string Tecnologia
    {
        get { return _tecnologia; }
        set { _tecnologia = value; }
    }

    public Modulo()
    {
        _tecnologia = "GPS";
    }
}