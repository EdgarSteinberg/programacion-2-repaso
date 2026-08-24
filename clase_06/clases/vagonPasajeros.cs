namespace Clase_06.clases;

public class VagonPasajeros : Vagon
{
    public VagonPasajeros(int cantidadDePasajeros, double largo, double anchoUtil)
    {
        _cantidadPasajeros = cantidadDePasajeros;
        _largo = largo;
        _anchoUtil = anchoUtil;
    }
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


    public int CantidadDePasajeros()
    {
        if (AnchoUtil <= 2.5)
        {
            return (int)(Largo * 8);
        }
        else
        {
            return (int)(Largo * 8);
        }
    }
    
    public override double CalcularPesoMaximo()
    {
        return CantidadDePasajeros() * 80;
    }
}