static string coinFlip()
{
    string[] results = {"Heads", "Tails"};
    Random index = new Random();
    return results[index.Next(0,2)];
}

Console.WriteLine(coinFlip());

static int diceRoll(int side)
{
    Random num = new Random();
    return num.Next(1,side+1);
}

Console.WriteLine(diceRoll(6));

static List<int> statRoll(int times, int sides)
{
    List<int> stats = new List<int>();
    int largest = 0;
    for( int i = 0; i < times; i++)
    {
        stats.Add(diceRoll(sides));
        if(largest< stats[i]){
            largest = stats[i];
        }
    }
    Console.WriteLine($"The largest value you rolled is {largest}");
    return stats;
}

List<int> stats = new List<int>();
stats = statRoll(7,6);
foreach (int val in stats)
{
    Console.WriteLine(val);
}

static string rollUntil(int result)
{
    int val = diceRoll(6);
    int count = 1;
    while(val != result)
    {
        val = diceRoll(6);
        count++;
    }
    return $"Rolled a {result} after {count} tries";
}

Console.WriteLine(rollUntil(3));