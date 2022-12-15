Soda GingerAle = new Soda("Ginger Ale", "Brown", 32, 100, false);
Coffee Espresso = new Coffee("Espresso", "Dark Brown", 120, 90, "Dark", "Arabica");
Wine Merlot = new Wine("Merlot", "Red", 40, 120, "France", 2010);

List<Drink> AllBeverages = new List<Drink>() {GingerAle, Espresso, Merlot};

foreach( Drink drink in AllBeverages)
{
    drink.ShowDrink();
}

// Coffee MyDrink = new Soda("Ginger Ale", "Brown", 32, 100, false);
// Will not work as we're trying to cast a soda as a coffee