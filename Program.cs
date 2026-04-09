
wizard wizardA = new wizard("Ralsei", 10);
wizard wizardB = new wizard("John shaman",10);
while (wizardA.Energy)
{

}
class wizard
{
    string Name;
    public int Energy;
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