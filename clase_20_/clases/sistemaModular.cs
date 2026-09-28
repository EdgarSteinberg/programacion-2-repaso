namespace clase_20_clases;

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
        _Procesamiento = procesamiento;
        _documento = documento;
    }

    public void ProcesarDocumento(Documento documento)
    {
        _iProcesamiento.Procesar(documento);
    }

}