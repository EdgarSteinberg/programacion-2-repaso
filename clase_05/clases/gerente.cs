namespace Clase_05.clases;

public class Gerente : Empleado
{
    public Gerente(string nombre, double sueldoNeto, int inasisencias, int objetivo, BonoResultado bonoResultado, BonoPresentismo bonoPresentismo) : base(nombre, 1000, inasisencias, objetivo, bonoResultado, bonoPresentismo)
    {

    }
}