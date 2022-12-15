List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? ChileEruption = eruptions.FirstOrDefault(o => o.Location == "Chile");
Console.WriteLine(ChileEruption.ToString());

// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? Hawaiian = eruptions.FirstOrDefault(h => h.Location == "Hawaiian Is");
if(Hawaiian == null)
{
    Console.WriteLine("No Hawaiian Is eruption found.");
}
else
{
    Console.WriteLine(Hawaiian.ToString());
}

// Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption? Greenland = eruptions.FirstOrDefault(g => g.Location == "Greenland");
if(Greenland == null)
{
    Console.WriteLine("No Greenland eruption found.");
}
else
{
    Console.WriteLine(Greenland.ToString());
}

// Find all eruptions where the volcano's elevation is over 2000m and print them.
List<Eruption> Elevation = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
PrintEach(Elevation, "Elevation over 2000");

// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> StartsWithL = eruptions.Where(s => s.Volcano.StartsWith("L")).ToList();
PrintEach(StartsWithL, "All volcanos that start with L");

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int HighestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Highest Elevation is {HighestElevation}");

// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
Eruption? Highest = eruptions.FirstOrDefault(h => h.ElevationInMeters == HighestElevation);
Console.WriteLine($"Name: {Highest.Volcano}, Elevation in meters: {Highest.ElevationInMeters}");

// Print all Volcano names alphabetically.
List<string> names = eruptions.OrderBy(e => e.Volcano).Select(n => n.Volcano).ToList();
Console.WriteLine("All Volcano names in alphabetical order:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Print the sum of all the elevations of the volcanoes combined.
int sum = eruptions.Sum(s => s.ElevationInMeters);
Console.WriteLine($"Sum of all elevations: {sum}");

// Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool year200 = eruptions.Any(y => y.Year == 2000);
Console.WriteLine("Any volvanoes erupted in 2000?");
if(year200 == true) Console.WriteLine("Yes");
else Console.WriteLine("No");

// Find all stratovolcanoes and print just the first three (Hint: look up Take)
List<Eruption> stratovolcanoes = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
PrintEach(stratovolcanoes, "First three stratovolcanoes");

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List<Eruption> happenedBefore1000 = eruptions.OrderBy(e => e.Volcano).Where(e => e.Year < 1000).ToList();
PrintEach(happenedBefore1000, "All volvanoes that happened before year 1000 in alphabetical order");

// Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> allVolcanoes1000 = eruptions.OrderBy(e => e.Volcano).Where(e => e.Year < 1000).Select(e => e.Volcano).ToList();
Console.WriteLine("All volcanoes before year 1000");
foreach (string volcano in allVolcanoes1000)
{
    Console.WriteLine(volcano);
}

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}