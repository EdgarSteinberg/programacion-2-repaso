namespace clase_20_clases;

public class Compresion : IProcesamiento
{
    public void Procesar(Documento documento)
    {
        documento.Contenido = "Documento comprimido";
    }
}