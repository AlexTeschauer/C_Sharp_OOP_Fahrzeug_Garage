public abstract class Person
{
    protected string Vorname {get; set; }
    protected string Nachname {get; set; }
    protected int Alter {get; set; }

    public Person(string vorname, string nachname, int alter)
    {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Alter = alter;
    }

    public string GetVorname()
    {
        return this.Vorname;
    }

    public string GetNachname()
    {
        return this.Nachname;
    }

    public int GetAlter()
    {
        return this.Alter;
    }

    public void SetVorname(string vorname)
    {
        this.Vorname = vorname;
    }

    public void SetNachname(string nachname)
    {
        this.Nachname = nachname;
    }

    public void SetAlter(int alter)
    {
        if (alter < 0)
            throw new Exception("Alter muss positiv sein.");
        else if (alter < 18)
            throw new Exception("Person muss volljährig sein.");
        else
            this.Alter = alter;
    }
}