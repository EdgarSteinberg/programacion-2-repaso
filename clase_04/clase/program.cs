using clase_04.Clases;

Alumno objAlumno = new Alumno("Juan", "Perez", "alumno@email.com", "12345", 8.5f);

Docente objDocente = new Docente("Edgar", "Stein", "Stein@example.com", "Programacion", 4);

/* Console.WriteLine(objAlumno.Saludar()); */
/* Console.WriteLine(objDocente.Saludar()); */

Printer.Print(objAlumno);
Printer.Print(objDocente);

