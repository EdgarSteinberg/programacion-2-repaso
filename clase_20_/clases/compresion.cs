namespace clase_20_.clases;

public class Compresion : IProcesamiento
{
    public void Procesar(Documento documento)
    {
        documento.Contenido = "Documento comprimido";
    }
}