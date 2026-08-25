namespace Clase_06.clases;

public class Formacion
{
    public Formacion(Locomotora locomotora)
    {
        _locomotoras = new List<Locomotora>();
        _locomotoras.Add(locomotora);

        _vagones = new List<Vagon>();
        _estaEnMovimiento = false;
    }

    private List<Locomotora> _locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }

    private List<Vagon> _vagones;
    public List<Vagon> Vagones
    {
        get { return _vagones; }
        set { _vagones = value; }
    }

    private bool _estaEnMovimiento;
    public bool EstaEnMovimiento
    {
        get { return _estaEnMovimiento; }
        set { _estaEnMovimiento = value; }
    }

    public void AgregarLocomotora(Locomotora locomotora)
    {
        if (EstaEnMovimiento)
        {
            throw new Exception("No se puede agregar una locomotora con una formación en movimiento");
        }

        _locomotoras.Add(locomotora);
    }
    public void AgregarVagon(Vagon vagon)
    {
        _vagones.Add(vagon);
    }


    //El total de pasajeros que puede transportar una formació
    public int CalcularTotalDePasajeros()
    {
        int totalPasajeros = 0;

        foreach (var vagon in Vagones)
        {
            if (vagon is VagonPasajeros vagonPasajeros)
            {
                totalPasajeros += vagonPasajeros.CantidadDePasajeros();
            }
        }

        return totalPasajeros;
    }

    /*Cuántos vagones livianos tiene una formación; un vagón es liviano si su peso máximo es
    menor a 2500 kg */

    public int CalcularCantidadVagonesLivianos()
    {
        int cantidad = 0;

        foreach (var vagon in _vagones)
        {
            if (vagon.CalcularPesoMaximo() < 2500)
            {
                cantidad++;
            }
        }

        return cantidad;
    }


    /*La velocidad máxima de una formación, que es el mínimo entre las velocidades máximas
      de las locomotoras.*/
    public double CalcularVelocidadMaxima()
    {
        double velocidadMaxima = Locomotoras[0].VelocidadMaxima;

        foreach (var locomotora in Locomotoras)
        {
            if (locomotora.VelocidadMaxima < velocidadMaxima)
            {
                velocidadMaxima = locomotora.VelocidadMaxima;
            }
        }

        return velocidadMaxima;
    }

    /*Si una formación es eficiente; es eficiente si cada una de sus locomotoras arrastra, al
      menos, 5 veces su peso (el de la locomotora misma). */
    public bool FormacionEsEficiente()
    {
        foreach (var locomotora in Locomotoras)
        {
            if (locomotora.PesoMaximoArrastre < locomotora.Peso * 5)
            {
                return false;
            }
        }

        return true;
    }


    /*Si una formación puede moverse. Una formación puede moverse si el arrastre útil total de
      las locomotoras es mayor o igual al peso máximo total de los vagones.*/
    public bool PuedeMoverse()
    {
        double pesoTotalVagones = 0;
        double arrastreUtilTotal = 0;

        foreach (var vagon in _vagones)
        {
            pesoTotalVagones += vagon.CalcularPesoMaximo();
        }

        foreach (var locomotora in _locomotoras)
        {
            arrastreUtilTotal += locomotora.CalcularArrastreUtil();
        }

        return arrastreUtilTotal >= pesoTotalVagones;
    }

    /*  public bool PuedeMoverse()
    {
        return CalcularEmpujeFaltante() == 0;
    } */



    /*Cuántos kilos de empuje le faltan a una formación para poder moverse, que es: 0 si ya se
    puede mover, y (peso máximo total de los vagones – arrastre útil total de las locomotoras)
    en caso contrario.*/

    public double CalcularEmpujeFaltante()
    {
        double pesoVagones = 0;
        double arrastreDisponible = 0;

        foreach (var vagon in _vagones)
        {
            pesoVagones += vagon.CalcularPesoMaximo();
        }

        foreach (var locomotora in _locomotoras)
        {
            arrastreDisponible += locomotora.CalcularArrastreUtil();
        }

        if (pesoVagones > arrastreDisponible)
        {
            return pesoVagones - arrastreDisponible;
        }

        return 0;
    }



    /*Si un depósito necesita un conductor experimentado. Un depósito necesita un conductor
    experimentado si alguna de sus formaciones es compleja. Una formación es compleja si:
    tiene más de 20 unidades (sumando locomotoras y vagones), o el peso total (sumando
    locomotoras y vagones) es de más de 10000 kg.
    */

    public bool EsCompleja()
    {
        int unidades = Locomotoras.Count + Vagones.Count;

        double pesoTotal = 0;

        foreach (var locomotora in Locomotoras)
        {
            pesoTotal += locomotora.Peso;
        }

        foreach (var vagon in Vagones)
        {
            pesoTotal += vagon.CalcularPesoMaximo();
        }

        return unidades > 20 || pesoTotal > 10000;
    }
}