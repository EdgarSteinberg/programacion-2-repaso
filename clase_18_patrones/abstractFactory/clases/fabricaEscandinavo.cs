namespace clase_18_patrones.abstractFactory.clases;
public class FabricaEscandinavo : FabricaAbstracta
{
    public override MesaAbstracta CrearMesa()
    {
        return new MesaEscandinavo();
    }

     public override SillaAbstracta CrearSilla()
    {
        return new SillaEscandinavo();
    }
}