MeleeFighter Pirate = new MeleeFighter("Pirate");
RangedFighter Ninja = new RangedFighter("Ninja");
MagicCaster Sensei = new MagicCaster("Sensie");

Pirate.RandomAttack();
Pirate.Rage();
Ninja.RandomAttack();
Ninja.Dash();
Ninja.RandomAttack();
Sensei.RandomAttack();
Sensei.Heal(Ninja);
Sensei.Heal(Sensei);