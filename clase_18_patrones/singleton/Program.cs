using clase_18_patrones.singleton.clases;


Presidente.Eleccion("Edgar", "Steinberg");
Presidente objPresidente = Presidente.DevolverInstancia();
Console.WriteLine($"El presidente es {objPresidente.Nombre} {objPresidente.Apellido}");


Presidente.Eleccion("Need", "Flanders");
objPresidente = Presidente.DevolverInstancia();
Console.WriteLine($"El presidente es {objPresidente.Nombre} {objPresidente.Apellido}");