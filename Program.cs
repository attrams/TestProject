Random random = new Random();
int heroAttackPoint = 0;
int monsterAttackPoint = 0;

int heroHealthPoints = 10;
int monsterHealthPoints = 10;

do
{
    heroAttackPoint = random.Next(1, 11);
    monsterAttackPoint = random.Next(1, 11);

    monsterHealthPoints -= heroAttackPoint;
    if (monsterHealthPoints < 1)
    {
        Console.WriteLine($"Monster was damaged and lost {heroAttackPoint} health and now has {monsterHealthPoints} health.");
        Console.WriteLine("Hero wins");
        break;
    }
    else
    {
        Console.WriteLine($"Monster was damaged and lost {heroAttackPoint} health and now has {monsterHealthPoints} health.");
    }

    heroHealthPoints -= monsterAttackPoint;
    if (heroHealthPoints < 1)
    {
        Console.WriteLine($"Hero was damaged and lost {monsterAttackPoint} health and now has {heroHealthPoints} health.");
        Console.WriteLine("Monster wins");
        break;
    }
    else
    {
        Console.WriteLine($"Hero was damaged and lost {monsterAttackPoint} health and now has {heroHealthPoints} health.");
    }

} while ((heroHealthPoints > 1) || (monsterHealthPoints > 1));