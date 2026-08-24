using Clase_06.clases;


Formacion formacion = new Formacion(false);

Locomotora locomotora = new Locomotora(1000, 12000);


Console.WriteLine($"Locomotora arrastre util: {locomotora.CalcularArrastreUtil()}");

Deposito deposito = new Deposito();

deposito.AgregarLocomotoraEnFormacion(locomotora, formacion);
