namespace clase_18_patrones.abstractFactory.clases;
public class FabricaVictoriana : FabricaAbstracta 
{ 
    public override MesaAbstracta CrearMesa() 
    { 
        return new MesaVictoriana(); 
    } 
 
    public override SillaAbstracta CrearSilla() 
    { 
        return new SillaVictoriana(); 
    } 
}