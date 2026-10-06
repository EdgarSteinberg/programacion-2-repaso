using clase_22.adapter.clases;

ServicioEmailViejo servicioViejo = new ServicioEmailViejo();

INotificador adapter = new EmailAdapter(servicioViejo);

NotificacionService service = new NotificacionService(adapter);

service.Notificar("Hola Edgar");