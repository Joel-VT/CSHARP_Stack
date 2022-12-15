class Vehicle
{
    string name;
    int passengers;
    string color;
    bool hasEngine;
    int topSpeed;
    double miles;

    public Vehicle(string n, int p, string c, bool hE, int tS)
    {
        name = n;
        passengers = p;
        color = c;
        hasEngine = hE;
        topSpeed = tS;
        miles = 0;
    }

    public Vehicle(string n, string c)
    {
        name = n;
        color = c;
        passengers = 1;
        hasEngine = false;
        topSpeed = 10;
        miles = 0;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name} Passengers: {passengers} Color: {color} Has Engine: {hasEngine} Top Speed: {topSpeed} Miles: {miles}");
    }

    public void Travel(double m)
    {
        miles+=m;
        Console.WriteLine($"The vehicle has gone {miles}");
    }
}