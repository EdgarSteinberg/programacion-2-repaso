namespace Clase_06.clases;


public class Deposito
{
    private List<Locomotora> _locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    private List<Formacion> _formaciones;
    public List<Formacion> Formaciones
    {
        get { return _formaciones; }
        set { _formaciones = value; }
    }

    public void AgregarLocomotoraEnFormacion(Locomotora locomotora, Formacion formacion)
    {
        if (!formacion.EstaEnMovimiento)
        {
            formacion.Locomotoras.Add(locomotora);
        }
    }
}