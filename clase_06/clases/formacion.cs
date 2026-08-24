namespace Clase_06.clases;

public class Formacion
{
    public Formacion(bool estaEnMovimiento)
    {
        _estaEnMovimiento = estaEnMovimiento;
        _locomotoras = new List<Locomotora>();
    }

    private List<Locomotora> _locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    /*  private List<Vagon> _vagones;
        public List<Vagon> Vagones
        {
            get { return _vagones; }
            set { _vagones = value; }
        } */

    private bool _estaEnMovimiento;
    public bool EstaEnMovimiento
    {
        get { return _estaEnMovimiento; }
        set { _estaEnMovimiento = value; }
    }
}