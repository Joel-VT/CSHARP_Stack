class Enemy
{
    string Name;
    int Health;
    List<Attack> AllAttacks = new List<Attack>();

    public Enemy(string n)
    {
        Name = n;
        Health = 100;
    }
    public void ShowHealth()
    {
        Console.WriteLine($"Health: {Health}");
    }

    public void RandomAttack()
    {
        Random indx = new Random();
        Console.WriteLine(AllAttacks[indx.Next(0,AllAttacks.Count)].Name);
    }

    public void AddAttack(Attack NewAttack)
    {
        AllAttacks.Add(NewAttack);
        foreach(Attack OneAttack in AllAttacks)
        {
            Console.WriteLine($"Name: {OneAttack.Name}, Damage: {OneAttack._Damage}");
        }
    }
}