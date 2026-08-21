namespace Clase_06.clases;

public class Locomotora
{
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
    

    private Bool _estaEnMovimiento;
    public Bool EstaEnMovimiento
    {
        get { return _estaEnMovimiento; }
        set { _estaEnMovimiento = value; }
    }

    public double CalcularArrastreUtil()
    {
        return PesoMaximoArrastre - Peso;
    }

}