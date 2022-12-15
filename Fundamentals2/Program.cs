int[] integers = {0,1,2,3,4,5,6,7,8,9};

string[] names = {"Tim", "Martin", "Nikki", "Sara"};

bool[] array = new bool[10];
for (int i = 0; i <array.Length; i++)
{
    if(i%2==0){
        array[i] = true;
    }
    else
    {
        array[i] = false;
    }
}

List<string> flavors = new List<string>() {"Chocolate", "Vanilla", "Mint", "Bubblegum", "Cookie Dough"};

foreach(string item in flavors)
{
    Console.WriteLine(item);
}

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);

flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);

Dictionary<string,string> dictionary = new Dictionary<string, string>();

Random index = new Random();
foreach(string name in names){
    dictionary.Add(name, flavors[index.Next(0,flavors.Count+1)]);
}

foreach(KeyValuePair<string,string> entry in dictionary)
{
    Console.WriteLine(entry.Key + " : " + entry.Value);
}
