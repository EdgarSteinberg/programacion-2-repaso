using clase_22.chainResponsability.clases;


Empleado empleado = new Empleado("Edgar", "Steinberg");
Jefe jefe = new Jefe();
Gerente gerente = new Gerente();

empleado.ElegirSiguienteAprobador(jefe);
jefe.ElegirSiguienteAprobador(gerente);

empleado.AprobarCompra(150);
empleado.AprobarCompra(500);
/* empleado.AprobarCompra(3000); */