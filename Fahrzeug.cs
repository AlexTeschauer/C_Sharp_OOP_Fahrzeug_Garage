public abstract class Fahrzeug
{
    protected int Autonummer { get; set; }
    protected string Name { get; set; }
    protected string Baujahr { get; set; }
    protected string Kennzeichen { get; set; }
    protected string Hersteller { get; set; }
    protected bool IstAusgeliehen { get; set; }
    protected Person Ausleiher { get; set; }

    public Fahrzeug(int autonummer, string name, string baujahr, string kennzeichen, string hersteller, Person ausleiher)
    {
        this.Autonummer = autonummer;
        this.Name = name;
        this.Baujahr = baujahr;
        this.Kennzeichen = kennzeichen;
        this.Hersteller = hersteller;
        this.IstAusgeliehen = false;
        this.Ausleiher = ausleiher;
    }

    public int GetAutonummer()
    {
        return this.Autonummer;
    }

    public void SetAutonummer(int autonummer)
    {
        this.Autonummer = autonummer;
    }

    public string GetName()
    {
        return this.Name;
    }

    public string GetBaujahr()
    {
        return this.Baujahr;
    }

    public string GetKennzeichen()
    {
        return this.Kennzeichen;
    }

    public string GetHersteller()
    {
        return this.Hersteller;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }

    public void SetBaujahr(string baujahr)
    {
        this.Baujahr = baujahr;
    }

    public void SetKennzeichen(string kennzeichen)
    {
        this.Kennzeichen = kennzeichen;
    }

    public void SetHersteller(string hersteller)
    {
        this.Hersteller = hersteller;
    }

    public bool GetIstAusgeliehen()
    {
        return this.IstAusgeliehen;
    }

    public void SetIstAusgeliehen(bool istAusgeliehen)
    {
        this.IstAusgeliehen = istAusgeliehen;
    }

    public Person GetAusleiher()
    {
        return this.Ausleiher;
    }

    public void SetAusleiher(Person ausleiher)
    {
        this.Ausleiher = ausleiher;
    }

    public abstract void Fahren();
    // {
    //     Console.WriteLine("Fahrzeug fährt.");
    // }

    public abstract void Beschleunigen();
    // {
    //     Console.WriteLine("Fahrzeug beschleunigt.");
    // }
}