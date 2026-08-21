namespace Clase_06.clases;

public class VagonPasajeros : Vagon
{
    private int _cantidadPasajeros;
    public int CantidadPasajeros
    {
        get { return _cantidadPasajeros; }
        set { _cantidadPasajeros = value; }
    }

    private double _largo;
    public double Largo
    {
        get { return _largo; }
        set { _largo = value; }
    }

    private double _anchoUtil;
    public double AnchoUtil
    {
        get { return _anchoUtil; }
        set { _anchoUtil = value; }
    }


    public double CantidadDePasajeros()
    {
        if (AnchoUtil <= 2.5)
        {
            return Largo * 8;
        }
        else if (AnchoUtil > 2.5)
        {
            return Largo * 8;
        }
    }
    public override double CalcularPesoMaximo()
    {
        return CantidadDePasajeros() * 80;
    }
}