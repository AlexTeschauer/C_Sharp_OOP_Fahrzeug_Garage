public class Volkswagen : Benziner
{
    public Volkswagen(int autonummer, string name, string baujahr, string kennzeichen, string hersteller, Person ausleiher, double betankzeit) : base(autonummer, name, baujahr, kennzeichen, hersteller, ausleiher, betankzeit)
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
}