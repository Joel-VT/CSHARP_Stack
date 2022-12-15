Attack Attack1 = new Attack("Slap", 10);
Attack Attack2 = new Attack("Punch", 15);
Attack Attack3 = new Attack("Kick", 20);

Enemy Enemy1 = new Enemy("Brutus");

Enemy1.AddAttack(Attack1);
Enemy1.AddAttack(Attack2);
Enemy1.AddAttack(Attack3);

Enemy1.RandomAttack();