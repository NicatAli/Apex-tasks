class Student
{
    private static int lastAge = 20;
    public int Age { get; private set; }

    public Student()
    {
        Age = ++lastAge;
    }

}

class Program
{ 
   static void Main(string[] args)
    {
        Student tamerlan = new Student();
        Console.WriteLine(tamerlan.Age);

        Student faiq = new Student();
        Console.WriteLine(faiq.Age);

        Student tural = new Student();
        Console.WriteLine(tural.Age);

        Student emil = new Student();
        Console.WriteLine(emil.Age);
    }



}
