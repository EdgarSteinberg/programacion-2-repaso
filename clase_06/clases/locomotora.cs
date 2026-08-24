namespace Clase_06.clases;

public class Locomotora
{
    public Locomotora(double peso, double pesoMaximoArrastre)
    {
        _peso = peso;
        _pesoMaximoArrastre = pesoMaximoArrastre;
        _velocidadMaxima = 80;
    }
    private double _peso;
    public double Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    private double _pesoMaximoArrastre;
    public double PesoMaximoArrastre
    {
        get { return _pesoMaximoArrastre; }
        set { _pesoMaximoArrastre = value; }
    }

    private double _velocidadMaxima;
    public double VelocidadMaxima
    {
        get { return _velocidadMaxima; }
        set { _velocidadMaxima = value; }
    }

    public double CalcularArrastreUtil()
    {
        return PesoMaximoArrastre - Peso;
    }

}