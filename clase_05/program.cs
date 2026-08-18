using Clase_05.clases;

Empresa empresa = new Empresa();

BonoResultado bonoResultado = new BonoResultado();
BonoPresentismoA bonoA = new BonoPresentismoA();

Empleado objGerente = new Gerente(
    "Edgar",
    10000,
    1,
    100,
    bonoResultado,
    bonoA
);

empresa.AgregarEmpleado(objGerente);

Console.WriteLine(empresa.CalcularSueldoEmpleado(objGerente));