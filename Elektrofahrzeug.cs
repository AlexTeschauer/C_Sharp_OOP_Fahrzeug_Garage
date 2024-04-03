public abstract class Elektrofahrzeug : Fahrzeug
{
    double Ladezeit {get; set; }

    public Elektrofahrzeug(int autonummer, string name, string baujahr, string kennzeichen, string hersteller, Person ausleiher, double ladezeit) : base(autonummer, name, baujahr, kennzeichen, hersteller, ausleiher)
    {
        this.Ladezeit = ladezeit;
    }

    public double GetLadezeit()
    {
        return this.Ladezeit;
    }

    public void SetLadezeit(double ladezeit)
    {
        this.Ladezeit = ladezeit;
    }
}