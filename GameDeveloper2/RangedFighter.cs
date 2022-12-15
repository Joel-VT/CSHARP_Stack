class RangedFighter : Enemy
{
    int Distance;
    public RangedFighter(string n) : base(n)
    {
        AddAttack(new List<Attack>() {new Attack("Shoot an Arrow",20),new Attack("Throw a Knife",15)});
        Distance = 5;
    }

    public override void RandomAttack()
    {
        if(Distance >= 10)
        {
            base.RandomAttack();
        }
        else
        {
            Console.WriteLine("Not enough distance to perform attack");
        }
    }

    public void Dash()
    {
        Distance = 20;
    }
}