using clase_18_patrones.composite.clases;

Carpeta carpetaPrincipal = new Carpeta("Disco C", "Disco C".Length);

AnalizadorDeElemento(carpetaPrincipal);

Archivo archivoPesado = new Archivo("El retorno del rey.mp4", 2048);
AnalizadorDeElemento(archivoPesado);
Archivo archivoLiviano = new Archivo("misContrasenas.txt", 10);
AnalizadorDeElemento(archivoLiviano);

carpetaPrincipal.Agregar(archivoPesado);
carpetaPrincipal.Agregar(archivoLiviano);

Carpeta otraCarpeta = new Carpeta("Documentos", 10);
Archivo cv = new Archivo("Cv.docx", 500);
otraCarpeta.Agregar(cv);

AnalizadorDeElemento(otraCarpeta);
AnalizadorDeElemento(carpetaPrincipal);

carpetaPrincipal.Agregar(otraCarpeta);
AnalizadorDeElemento(carpetaPrincipal);

void AnalizadorDeElemento(Elemento unElemento)
{
    Console.WriteLine($"El elemento {unElemento.Nombre} peso {unElemento.DevolverTamano()} MB");
}