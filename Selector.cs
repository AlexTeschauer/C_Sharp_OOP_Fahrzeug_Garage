public abstract class Selector
{
    public static int SelectCar()
    {
        Console.WriteLine("Bitte geben Sie die Nummer des Fahrzeugs ein, das ausgeliehen werden soll:");
        return Convert.ToInt32(Console.ReadLine());
    }
}