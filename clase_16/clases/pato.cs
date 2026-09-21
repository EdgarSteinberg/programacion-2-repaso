namespace clase_16.clases;

public class Pato : ICuack, INadador, IVolador
{
    public void Nadar()
    {
        Console.WriteLine("El pato esta Nadando");
    }

    public void Volar()
    {
        Console.WriteLine("El pato esta Volando");
    }

     public void Cuack()
    {
        Console.WriteLine("El pato esta Cuack");
    }
}