namespace Interfaces_M1;

// Tâche 4 : seconde classe qui implémente IPerson avec un comportement différent,
// et aussi IEmployee. Les deux interfaces ont DisplayInfo() :
// on les implémente EXPLICITEMENT pour donner un comportement à chacune.
public class Teacher : IPerson, IEmployee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Subject { get; set; }
    public string EmployeeId { get; }

    public Teacher(string name, int age, string subject, string employeeId)
    {
        Name = name;
        Age = age;
        Subject = subject;
        EmployeeId = employeeId;
    }

    // Implémentation explicite : pas de "public", préfixée par le nom de l'interface.
    // Accessible seulement via une variable de type IPerson.
    void IPerson.DisplayInfo()
    {
        Console.WriteLine($"Teacher: {Name}, {Age} years old, teaches {Subject}.");
    }

    // Accessible seulement via une variable de type IEmployee.
    void IEmployee.DisplayInfo()
    {
        Console.WriteLine($"Employee #{EmployeeId}: {Name}, department of {Subject}.");
    }
}
