namespace clase_16.clases;

public class PatoDeGoma : INadador, ICuack
{
    public void Nadar()
    {
        Console.WriteLine("El pato esta Nadando");
    }

    public void Cuack()
    {
        Console.WriteLine("El pato esta Cuack");
    }
}