using Clase_06.clases;


Locomotora locomotora = new Locomotora(1000, 12000);
Formacion formacion = new Formacion(locomotora);


Console.WriteLine($"Locomotora arrastre util: {locomotora.CalcularArrastreUtil()}");

Deposito deposito = new Deposito();

deposito.AgregarLocomotoraEnFormacion(locomotora, formacion);
