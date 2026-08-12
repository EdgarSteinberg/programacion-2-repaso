
Robot robotina = new Robot("Robotina 2000", 100, new RuedaDeCaucho());
Console.WriteLine(robotina.MostrarInformacion());
robotina.Recorrer();
Console.WriteLine(robotina.MostrarInformacion());
robotina.Recorrer();
Console.WriteLine(robotina.MostrarInformacion());

Console.WriteLine("----------------");

Robot oruga = new Robot("Oruga 2000", 100, new Oruga());
Console.WriteLine(oruga.MostrarInformacion());
oruga.Recorrer();
Console.WriteLine(oruga.MostrarInformacion());
oruga.Recorrer();
Console.WriteLine(oruga.MostrarInformacion());

public class Robot
{
    private string _numeroDeSerie;
    public string NumeroDeSerie
    {
        get { return _numeroDeSerie; }
        set { _numeroDeSerie = value; }
    }

    private int _potenciaBase;
    public int PotenciaBase
    {
        get { return _potenciaBase; }
        set { _potenciaBase = value; }
    }

    private TipoTraccion _tipoTraccion;
    public TipoTraccion TipoTraccion
    {
        get { return _tipoTraccion; }
        set { _tipoTraccion = value; }
    }

    public Robot(string numeroDeSerie, int potenciaBase, TipoTraccion tipoTraccion)
    {
        _numeroDeSerie = numeroDeSerie;
        _potenciaBase = potenciaBase;
        _tipoTraccion = tipoTraccion;
    }

    public void Recorrer()
    {
        this.PotenciaBase = this.PotenciaBase - this.TipoTraccion.DesgastePorUso;
    }

    public string MostrarInformacion()
    {
        return $"Numero de serie {this.NumeroDeSerie}, Potencia: {this.PotenciaBase}, Tipo de Traccion {this.TipoTraccion}, Autonomia: {this.TipoTraccion.Autonomia}, Desgaste por uso: {this.TipoTraccion.DesgastePorUso}";
    }
}

public abstract class TipoTraccion
{

    private int _desgastePorUso;
    public int DesgastePorUso
    {
        get { return _desgastePorUso; }
        set { _desgastePorUso = value; }
    }

    private int _autonomia;
    public int Autonomia
    {
        get { return _autonomia; }
        set { _autonomia = value; }
    }


}

public class RuedaDeCaucho : TipoTraccion
{
    public RuedaDeCaucho()
    {
        this.DesgastePorUso = 1;
        this.Autonomia = 100;
    }
}

public class Oruga : TipoTraccion
{
    private string _sensor;
    public string Sensor
    {
        get { return _sensor; }
        set { _sensor = value; }
    }

    public Oruga()
    {
        this.DesgastePorUso = 3;
        this.Autonomia = 400;
        this.Sensor = "Sensor de presión";
    }
}