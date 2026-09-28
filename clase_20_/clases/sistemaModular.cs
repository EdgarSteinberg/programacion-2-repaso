namespace clase_20_.clases;

public class SistemaModular
{
    private Documento _documento;
    public Documento Documento
    {
        get { return _documento; }
        set { _documento = value; }
    }

    private IProcesamiento _procesamiento;

    public IProcesamiento Procesamiento
    {
        get { return _procesamiento; }
        set { _procesamiento = value; }
    }

    public SistemaModular(IProcesamiento procesamiento, Documento documento)
    {
        _procesamiento = procesamiento;
        _documento = documento;
    }

    public void ProcesarDocumento(Documento documento)
    {
        _procesamiento.Procesar(documento);
    }

}