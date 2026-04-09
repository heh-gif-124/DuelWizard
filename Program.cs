
wizard wizardA = new wizard("Ralsei", 10);
wizard wizardB = new wizard("John shaman",10);
while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"{wizardA.Name}'s Energy: {wizardA.Energy}");
    Console.WriteLine($"{wizardB.Name}'s Energy: {wizardB.Energy}");
    Console.WriteLine($"1. {wizardA.Name} attacks {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} attacks {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} heals");
    Console.WriteLine($"4. {wizardB.Name} heals");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            wizardA.Attack(wizardB); break;
        case "2":
            wizardB.Attack(wizardA); break;
        case "3":
            wizardA.heal();
            break;
        case "4":
            wizardB.heal();
            break;
        default:
            Console.WriteLine("Thats not a command!!");
            break;
    }

}
class wizard
{
    public string Name;
    public int Energy;
    public int Damage;
    public wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    public void Attack(wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} attacked {enemyObj.Name}");
        Console.WriteLine($"{enemyObj.Name} has {enemyObj.Energy} left");
    }

    public void heal()
    {
        Random rand = new Random();
        int heal = rand.Next( 1, 5 );
        Energy += heal;
        if (Energy >= 100){
            Console.WriteLine("You cant heal anymore silly!");
        }
        else
        {
            Energy += heal;
            if (Energy > 100)
            {
                Energy = 100;
            }

            Console.WriteLine($"{Name} has healed!\nCurrent energy: {Energy}");
        }
    }
}