namespace Interfaces_M1;

// Tâche 3 : implémentation IMPLICITE de IPerson (membres publics).
public class Student : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }

    public Student(string name, int age, string major)
    {
        Name = name;
        Age = age;
        Major = major;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, {Age} years old, studies {Major}.");
    }
}
