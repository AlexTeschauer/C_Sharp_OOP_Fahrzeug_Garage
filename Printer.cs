public abstract class Printer
{
    public static void PrintFahrzeuge(List<Fahrzeug> fahrzeuge)
    {
        Console.WriteLine();
        Console.WriteLine("Fahrzeuge im Garage:");
        Console.WriteLine();

        foreach (Fahrzeug fahrzeug in fahrzeuge)
        {
            Console.WriteLine($"{fahrzeug.GetAutonummer()} | {fahrzeug.GetName()} | {fahrzeug.GetBaujahr()} | {fahrzeug.GetKennzeichen()} | {fahrzeug.GetHersteller()}");
        }

        Console.WriteLine();
    }

    public static void PrintIstAusgeliehen(Fahrzeug fahrzeug)
    {
        Console.WriteLine($"Ausleihzustand von {fahrzeug.GetName()}: {fahrzeug.GetIstAusgeliehen()}");
    }
    // DIP: Methoden, oder auch Klassen, hängen von Abstraktionen und nicht ihren Konkretisierungen ab. 
}