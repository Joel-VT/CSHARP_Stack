class MagicCaster : Enemy
{
    public MagicCaster(string n) : base(n,80)
    {
        AddAttack(new List<Attack>() {new Attack("Fireball",25),new Attack("Shield",0),new Attack("Staff Strike", 15)});
    }

    public void Heal(Enemy Target)
    {
        Target.AffectHealth(40);
        Target.ShowHealth();
    }
}