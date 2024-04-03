public class Garage
{
    private string Name {get; set; }
    private string Ort {get; set; }
    private int MaxKapazitaet {get; set; }
    public List<Fahrzeug> Fahrzeuge {get; set; } // DIP: Wir sind nicht von der Konkretisierung abhängt, sondern von der Abstraktion.

    public Garage(string name, string ort, int maxKapazitaet)
    {
        this.Name = name;
        this.Ort = ort;
        this.MaxKapazitaet = maxKapazitaet;
        this.Fahrzeuge = new List<Fahrzeug>();
    }

    public void FügeFahrzeugHinzu(Fahrzeug fahrzeug)
    {
        if (this.Fahrzeuge.Count < this.MaxKapazitaet)
            this.Fahrzeuge.Add(fahrzeug);
        else
            throw new Exception("Kapazität überschritten");
    }

    public void EntferneFahrzeug(Fahrzeug fahrzeug)
    {
        if (this.Fahrzeuge.Contains(fahrzeug))
        {
            this.Fahrzeuge.Remove(fahrzeug);
            Console.WriteLine($"Fahrzeug {fahrzeug.GetName()} mit dem Kennzeichen {fahrzeug.GetKennzeichen()} wurde entfernt.");
        }
        else
            throw new Exception("Fahrzeug nicht gefunden");
    }

    public void GibFahrzeugHeraus(Fahrzeug fahrzeug, Ausleiher ausleiher)
    {
        if (fahrzeug.GetIstAusgeliehen())
            throw new Exception("Fahrzeug ist bereits ausgeliehen");
        else
        {
            fahrzeug.SetIstAusgeliehen(true);
            fahrzeug.SetAusleiher(ausleiher);
            Console.WriteLine($"{fahrzeug.GetName()} mit dem Kennzeichen {fahrzeug.GetKennzeichen()} wurde von {ausleiher.GetVorname()} {ausleiher.GetNachname()} ausgeliehen.");
        }
    }

    public Fahrzeug GetFahrzeug(int ausleihe) // DIP: Abstraktion wird zurückgegeben, nicht die Konkretisierung.
    {
        for (int i = 0; i < Fahrzeuge.Count; i++)
        {
            if (Fahrzeuge[i].GetAutonummer() == ausleihe)
                return Fahrzeuge[i];
        }

        throw new Exception("Fahrzeug nicht gefunden.");
    }
}