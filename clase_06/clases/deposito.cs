namespace Clase_06.clases;

public class Deposito
{
    public Deposito()
    {
        _locomotoras = new List<Locomotora>();
        _formaciones = new List<Formacion>();
    }
    private List<Locomotora> _locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    private List<Formacion> _formaciones;
    public List<Formacion> Formaciones
    {
        get { return _formaciones; }
        set { _formaciones = value; }
    }

    public void AgregarLocomotoraEnFormacion(Locomotora locomotora, Formacion formacion)
    {
        formacion.AgregarLocomotora(locomotora);
    }

    public void AgregarFormacion(Formacion formacion)
    {
        _formaciones.Add(formacion);
    }
    /*Dado un depósito, el conjunto formado por el vagón más pesado de cada formación; se
    espera un conjunto de vagones.*/

    public List<Vagon> ObtenerVagonesMasPesados()
    {
        List<Vagon> vagonesPesados = new List<Vagon>();

        foreach (var formacion in _formaciones)
        {
            Vagon vagonMasPesado = formacion.Vagones[0];

            foreach (var vagon in formacion.Vagones)
            {
                if (vagon.CalcularPesoMaximo() > vagonMasPesado.CalcularPesoMaximo())
                {
                    vagonMasPesado = vagon;
                }
            }

            vagonesPesados.Add(vagonMasPesado);
        }

        return vagonesPesados;
    }

    /*Si un depósito necesita un conductor experimentado. Un depósito necesita un conductor
    experimentado si alguna de sus formaciones es compleja. Una formación es compleja si:
    tiene más de 20 unidades (sumando locomotoras y vagones), o el peso total (sumando
    locomotoras y vagones) es de más de 10000 kg.
    */

    public bool NecesitaConductorExperimentado()
    {
        foreach (var formacion in Formaciones)
        {
            if (formacion.EsCompleja())
            {
                return true;
            }
        }

        return false;
    }
    
}