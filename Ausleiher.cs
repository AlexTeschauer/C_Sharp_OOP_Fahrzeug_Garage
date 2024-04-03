public class Ausleiher : Person
{
    public Ausleiher(string vorname, string nachname, int alter) : base(vorname, nachname, alter)
    {

    }

    public void Ausleihen(Garage garage, Fahrzeug fahrzeug)
    {
        garage.GibFahrzeugHeraus(fahrzeug, this);
    }
}