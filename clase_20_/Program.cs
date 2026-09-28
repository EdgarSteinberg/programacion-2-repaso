using clase_20_.clases;

Documento document = new Documento("archivo.txt", "Hola Mundo");

IProcesamiento compresion = new Compresion();

SistemaModular sistema = new SistemaModular(compresion, document);

sistema.ProcesarDocumento(document);

Console.WriteLine(document.Contenido);

sistema.Procesamiento = new Encriptado();

sistema.ProcesarDocumento(document);

Console.WriteLine(document.Contenido);