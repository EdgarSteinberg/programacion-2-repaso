

using clase_16.sueldos.clases1;

Company compania = new Company();
BonoPresentismo bonoA = new BonoPresentismoA();
BonoPresentismo bonoB = new BonoPresentismoB();


Empleado empleado1 = new Empleado("Edgar",bonoA, 2000, 0 , 100);
compania.AgregarEmpleado(empleado1);
compania.MostraEmpleados();