using System;
using System.Text.RegularExpressions;

interface IAccount
{
    bool PasswordChecker(string password); 
    void ShowInfo(); 
}

class User : IAccount
{
    public string Fullname { get; set; }
    public string Email { get; set; }
    private string _password;

    public string Password
    {
       
        get { return _password; }

        set
        {
            if (PasswordChecker(value)) 
            {
                _password = value;
            }
            else
            {
                throw new Exception("The password does not comply with the specified rules!");
            }
        }
    }

    public bool PasswordChecker(string password)
    {

        if (password.Length < 8) return false;      
        if (!Regex.IsMatch(password, "[A-Z]")) return false;
        if (!Regex.IsMatch(password, "[a-z]")) return false;        
        if (!Regex.IsMatch(password, "[0-9]")) return false;

        return true; 
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Fullname: {Fullname}");
        Console.WriteLine($"Email: {Email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Name and Surname: ");
            string fullname = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: (At least 8 characters.\r\nAt least 1 uppercase letter.\r\nAt least 1 lowercase letter.\r\nAt least 1 digit.) ");
            string password = Console.ReadLine();

            User user = new User
            {
                Fullname = fullname,
                Email = email,
                Password = password 
            };

            Console.WriteLine("\nUser added succesfully!");
            user.ShowInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }
}
