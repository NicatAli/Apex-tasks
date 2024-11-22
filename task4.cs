class Person
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool IsAdult { get; private set; }

  
    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        IsAdult = age > 18; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Surname: ");
        string surname = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

       
        Person person = new Person(name, surname, age);

       
        Console.WriteLine($"\nName: {person.Name}");
        Console.WriteLine($"Surname: {person.Surname}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Is Adult? {(person.IsAdult ? "Yes" : "No")}");
    }
}