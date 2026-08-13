

using clase_04.Clases;

public static class Printer
{
    /* public static void Print(string message)
    {
        Console.WriteLine(message);
    }
 */
    public static void Print(Persona unaPersona)
    {
        Console.WriteLine(unaPersona.Saludar());
    }
}