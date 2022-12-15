class Coffee : Drink
{
    string Roast;
    string TypeOfBean;
    public Coffee(string name, string color, double temp, int calories, string roast, string type) : base(name, color, temp, false, calories)
    {
        Roast = roast;
        TypeOfBean = type;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine(Roast);
        Console.WriteLine(TypeOfBean);
    }
}