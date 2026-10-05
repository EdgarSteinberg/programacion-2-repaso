using clase_22.clases;

BaseSanitaria hospital =
    new Hospital("Durand", 5, 1, "Av. Díaz Vélez", 50);

BaseSanitaria uap =
    new Uap("MariaCuri", 0, 30, "Av. Ángel Gallardo", 20);

Ua ua =
    new Ua("Italiano", "Sarmiento");

ua.AgregarBaseSanitaria(hospital);
ua.AgregarBaseSanitaria(uap);

Console.WriteLine(ua.AmbulanciasDisponibles());
Console.WriteLine(ua.PromedioTiempoAsistencia());