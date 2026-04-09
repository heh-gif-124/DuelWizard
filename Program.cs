
wizard wizardA = new wizard("Ralsei", 10);
wizard wizardB = new wizard("John shaman",10);
class wizard
{
    string Name;
    int Energy;
    int Damage;
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
}