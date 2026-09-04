using clase_08.clases;

Console.WriteLine("Hello, World!");

Acme empresa = new Acme();

Micro micro1 = new Micro(10, 6, 130);

Fiaca fiaca = new Fiaca();
Clautrofobico clautrofobico = new Clautrofobico();
Apurado apurado = new Apurado();
Moderado moderado = new Moderado(3);
Obsecuente obesecuente = new Obsecuente(apurado);

empresa.AgregarMicro(micro1);

void ProbarEmpleado(Empleado empleado, Micro micro)
{
    try
    {
        micro.PuedeSubir(empleado);
        Console.WriteLine($"{empleado.GetType().Name} pudo subir al micro 🚌");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{empleado.GetType().Name} no pudo subir ❌: {ex.Message}");
    }
}

ProbarEmpleado(clautrofobico, micro1);
ProbarEmpleado(moderado, micro1);
ProbarEmpleado(obesecuente, micro1);
ProbarEmpleado(fiaca, micro1);
ProbarEmpleado(apurado, micro1);