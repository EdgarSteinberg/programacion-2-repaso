using clase_16.clases;



/* Pato pato = new Pato();
pato.Cuack();
pato.Nadar();
pato.Volar();


PatoDeGoma patoDeGoma = new PatoDeGoma();
patoDeGoma.Nadar(); */


/* INadador pato = new Pato();
pato.Nadar();

INadador patoDeGoma = new PatoDeGoma();
patoDeGoma.Nadar(); */

INadador pato = new Pato();
RecibirNadadores(pato);

INadador patoDeGoma = new PatoDeGoma();
RecibirNadadores(patoDeGoma);

PatoDeGoma patoDeGoma2 = new PatoDeGoma();
RecibirNadadores(patoDeGoma2);

static void RecibirNadadores(INadador objNadador)
{
    objNadador.Nadar();
}