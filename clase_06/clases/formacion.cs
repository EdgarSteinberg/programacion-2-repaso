namespace Clase_06.clases;

public class Formacion
{
    public Formacion(Locomotora locomotora)
    {
        _locomotoras = new List<Locomotora>();
        _locomotoras.Add(locomotora);

        _vagones = new List<Vagon>();
        _estaEnMovimiento = false;
    }

    private List<Locomotora> _locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    private List<Vagon> _vagones;
    public List<Vagon> Vagones
    {
        get { return _vagones; }
        set { _vagones = value; }
    }

    private bool _estaEnMovimiento;
    public bool EstaEnMovimiento
    {
        get { return _estaEnMovimiento; }
        set { _estaEnMovimiento = value; }
    }

    public void AgregarLocomotora(Locomotora locomotora)
    {
        if (EstaEnMovimiento)
        {
            throw new Exception("No se puede agregar una locomotora con una formación en movimiento");
        }

        _locomotoras.Add(locomotora);
    }
    public void AgregarVagon(Vagon vagon)
    {
        _vagones.Add(vagon);
    }

    public double CalcularEmpujeFaltante()
    {
        double pesoVagones = 0;
        double arrastreDisponible = 0;

        foreach(var vagon in _vagones)
        {
            pesoVagones += vagon.CalcularPesoMaximo();
        }

        foreach(var locomotora in _locomotoras)
        {
            arrastreDisponible += locomotora.CalcularArrastreUtil();
        }

        if(pesoVagones > arrastreDisponible)
        {
            return pesoVagones - arrastreDisponible;
        }

        return 0;
    }
}