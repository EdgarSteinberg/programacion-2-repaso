namespace clase_22.adapter.clases;


public class NotificacionService
{
    private INotificador _notificador;
    public INotificador Notificador
    {
        get { return _notificador; }
        set { _notificador = value; }
    }

    public NotificacionService(INotificador notificador)
    {
        _notificador = notificador;
    }

      public void Notificar(string mensaje)
    {
        _notificador.Enviar(mensaje);
    }

}