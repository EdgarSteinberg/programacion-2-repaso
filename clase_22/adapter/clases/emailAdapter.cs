namespace clase_22.adapter.clases;

public class EmailAdapter : INotificador
{
    private ServicioEmailViejo _servicioEmail;

    public EmailAdapter(ServicioEmailViejo servicioEmail)
    {
        _servicioEmail = servicioEmail;
    }

    public void Enviar(string mensaje)
    {
        _servicioEmail.MandarCorreo(mensaje);
    }
}