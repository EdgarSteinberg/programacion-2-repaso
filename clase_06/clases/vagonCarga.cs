
namespace Clase_06.clases;

public class VagonCarga : Vagon
{
    public VagonCarga(double cargaMaxima)
    {
        _cargaMaxima = cargaMaxima;       
    }
    private double _cargaMaxima;
    public double CargaMaxima
    {
        get { return _cargaMaxima; }
        set { _cargaMaxima = value; }
    }
    
    public override double CalcularPesoMaximo()
    {
        return CargaMaxima + 160;
    }
}
