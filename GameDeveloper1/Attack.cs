class Attack
{
    public string Name;
    int Damage;
    public int _Damage
    {
        get {return Damage;}
    }

    public Attack( string n, int d)
    {
        Name = n;
        Damage = d;
    }
}