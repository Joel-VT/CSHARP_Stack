class MeleeFighter : Enemy
{
    public MeleeFighter(string n) : base(n,120)
    {
        AddAttack(new List<Attack>() {new Attack("kick",15),new Attack("Punch",20),new Attack("Tackle", 25)});
    }

    public void Rage()
    {
        Random indx = new Random();
        Attack PlayedAttack = AllAttacks[indx.Next(0,AllAttacks.Count)];
        Console.WriteLine($"{Name} Performed {PlayedAttack.Name} and dealt a damage of {PlayedAttack._Damage+10}");
    }
}