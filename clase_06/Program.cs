using Clase_06.clases;

Locomotora locomotora = new Locomotora(1000, 12000);

Formacion formacion = new Formacion(locomotora);

VagonCarga vagon = new VagonCarga(12000);

formacion.AgregarVagon(vagon);

VagonPasajeros vagonPasajeros = new VagonPasajeros(0, 10, 2);

formacion.AgregarVagon(vagonPasajeros);

VagonPasajeros vagonPasajeros2 = new VagonPasajeros(0, 10, 3);

formacion.AgregarVagon(vagonPasajeros2);

VagonCarga vagonLiviano = new VagonCarga(2000);

formacion.AgregarVagon(vagonLiviano);


// Segunda formación para probar el método del depósito
Locomotora locomotora2 = new Locomotora(1000, 12000);

Formacion formacion2 = new Formacion(locomotora2);

VagonCarga vagonCarga2 = new VagonCarga(5000);

formacion2.AgregarVagon(vagonCarga2);


// Depósito
Deposito deposito = new Deposito();

deposito.AgregarFormacion(formacion);
deposito.AgregarFormacion(formacion2);


Console.WriteLine($"Arrastre útil: {locomotora.CalcularArrastreUtil()}");

Console.WriteLine($"Empuje faltante: {formacion.CalcularEmpujeFaltante()}");

Console.WriteLine($"Total de pasajeros que puede llevar la formacion: {formacion.CalcularTotalDePasajeros()}");

Console.WriteLine($"Cantidad de vagones livianos: {formacion.CalcularCantidadVagonesLivianos()}");

Console.WriteLine($"Velocidad maxima de la formacion: {formacion.CalcularVelocidadMaxima()}");

Console.WriteLine($"La formacion es eficiente? : {formacion.FormacionEsEficiente()}");

Console.WriteLine($"La formacion puede moverse? : {formacion.PuedeMoverse()}");


Console.WriteLine("\nVagones más pesados de cada formación:");

List<Vagon> vagonesPesados = deposito.ObtenerVagonesMasPesados();

foreach (var vagonPesado in vagonesPesados)
{
    Console.WriteLine($"Peso máximo: {vagonPesado.CalcularPesoMaximo()} kg");
}

Console.WriteLine($"La formacion necesita un conductor experimentado: {deposito.NecesitaConductorExperimentado()}");
