namespace clase_20_.clases;

public class Encriptado : IProcesamiento
{
    public void Procesar(Documento documento)
    {
        documento.Contenido = "Documento encriptado";
    }
}