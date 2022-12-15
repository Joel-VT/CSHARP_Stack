class Soda : Drink
{
    public bool Diet;
    public Soda(string name, string color, double temp, int calories, bool diet) : base(name, color, temp, true, calories)
    {
        Diet = diet;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine(Diet);
    }
}