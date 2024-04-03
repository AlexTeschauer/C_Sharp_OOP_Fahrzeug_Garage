public abstract class Benziner : Fahrzeug
{
    private double Betankzeit { get; set; }

    public Benziner(int autonummer, string name, string baujahr, string kennzeichen, string hersteller, Person ausleiher, double betankzeit) : base(autonummer, name, baujahr, kennzeichen, hersteller, ausleiher)
    {
        this.Betankzeit = betankzeit;
    }

    public double GetBetankzeit()
    {
        return this.Betankzeit;
    }

    public void SetBetankzeit(double betankzeit)
    {
        this.Betankzeit = betankzeit;
    }
}