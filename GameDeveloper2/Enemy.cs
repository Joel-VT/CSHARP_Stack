class Enemy
{
    public string Name;
    int Health;
    protected List<Attack> AllAttacks = new List<Attack>();

    public Enemy(string n, int h = 100)
    {
        Name = n;
        Health = h;
    }

    public void AffectHealth(int effect)
    {
        Health += effect;
        if(Health < 0)
        {
            Health = 0;
        }
    }
    public void ShowHealth()
    {
        Console.WriteLine($"Health: {Health}");
    }

    public virtual void RandomAttack()
    {
        Random indx = new Random();
        Attack PlayedAttack = AllAttacks[indx.Next(0,AllAttacks.Count)];
        Console.WriteLine($"{Name} Performed {PlayedAttack.Name} and dealt a damage of {PlayedAttack._Damage}");
    }

    public void AddAttack(List<Attack> AttackList)
    {
        AllAttacks = AttackList;
        foreach(Attack OneAttack in AllAttacks)
        {
            Console.WriteLine($"Name: {OneAttack.Name}, Damage: {OneAttack._Damage}");
        }
    }
}