public class Tesla : Elektrofahrzeug, IElektrofahrzeug
{
    public Tesla(int autonummer, string name, string baujahr, string kennzeichen, string hersteller, Person ausleiher, double ladezeit) : base(autonummer, name, baujahr, kennzeichen, hersteller, ausleiher, ladezeit)
    {

    }

    public override void Fahren()
    {
        Console.WriteLine($"{this.Name} fährt.");
    }

    public override void Beschleunigen()
    {
        Console.WriteLine($"{this.Name} beschleunigt.");
    }

    public void ConfigureSound()
    {
        Console.WriteLine("Sound.");
    }
}