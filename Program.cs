
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

    public void heal()
    {
        Random rand = new Random();
        int heal = rand.Next( 0, 5 );
        if (Energy <= 95){
            Energy += heal;
            Console.WriteLine($"{Name} has healed! \n Current energy: {Energy}");

        }
    }
}