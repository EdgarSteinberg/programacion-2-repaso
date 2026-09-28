namespace clase_20_clases;

public class Encriptado : IProcesamiento
{
    public void Procesar(Documento documento)
    {
        documento.Contenido = "Documento encriptado";
    }
}