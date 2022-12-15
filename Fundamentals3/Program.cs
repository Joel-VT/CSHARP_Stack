static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
}

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int item in IntList)
    {
        sum+=item;
    }
    Console.WriteLine(sum);
}

static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int item in IntList)
    {
        if(max<item){
            max=item;
        }
    }
    return max;
}



static List<int> SquareValues(List<int> IntList)
{
    for(int i =0; i < IntList.Count; i++){
        IntList[i]=IntList[i]*IntList[i];
    }
    return IntList;
}


static int[] NonNegatives(int[] IntArray)
{
    for(int i = 0; i < IntArray.Length; i++)
    {
        if(IntArray[i]<0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}


static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string,string> entry in MyDictionary)
    {
        Console.WriteLine(entry.Key + " : " + entry.Value);
    }
}

Dictionary<string,string> MyDictionary = new Dictionary<string, string>() {
    {"Name", "Joel"},
    {"Stack", "CSharp"},
    {"City", "DC"}
};


static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    foreach (KeyValuePair<string,string> entry in MyDictionary)
    {
        if(SearchTerm == entry.Key)
        {
            return true;
        }
    }
    return false;
}

static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> newDictionary = new Dictionary<string, int>();
    if(Names.Count != Numbers.Count)
    {
        return newDictionary;
    }
    for( int i = 0; i < Names.Count; i++ )
    {
        newDictionary.Add(Names[i], Numbers[i]);
    }
    return newDictionary;
}

// List<string> Names = new List<string>() {"Julie", "Harold", "James", "Monica"};
// List<int> Numbers = new List<int>() {6,12,7,10};
// Dictionary<string, int> NewDictionary = new Dictionary<string, int>();
// NewDictionary = GenerateDictionary(Names, Numbers);
// foreach (KeyValuePair<string,int> item in NewDictionary)
// {
//     Console.WriteLine(item.Key + " : " + item.Value);
// }