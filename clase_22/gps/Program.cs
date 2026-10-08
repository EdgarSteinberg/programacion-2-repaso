using clase_22.gps.clases;


SistemaViejo sistemaViejo = new SistemaViejo();

IAdapter adapter = new Adapter(sistemaViejo);

CentralMonitoreo central = new CentralMonitoreo(adapter);

central.ActualizarPosicion();