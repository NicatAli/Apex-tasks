using ConsoleApp12;

static void Main(string[] args)
{
    
    Warrior warrior = new Warrior("Warrior", 50, 15);
    Mage mage = new Mage("Mage", 40, 12);
    Archer archer = new Archer("Archer", 35, 10);

    
    warrior.Attack(mage);  
    Console.WriteLine();

    mage.Attack(archer);   
    Console.WriteLine();

    archer.Attack(warrior); 
    Console.WriteLine();
}
