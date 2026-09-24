using clase_18_patrones.abstractFactory.clases;


/* FabricaAbstracta fabrica = new FabricaVictoriana(); */
FabricaAbstracta fabrica = new FabricaEscandinavo();
MesaAbstracta mesa = fabrica.CrearMesa();
SillaAbstracta silla = fabrica.CrearSilla();

Console.WriteLine($"{mesa.Estilo}");
Console.WriteLine($"{silla.Estilo}");
