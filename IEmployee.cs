namespace Interfaces_M1;

// Deuxième interface, avec une méthode du MÊME NOM que dans IPerson.
// Elle sert à montrer l'implémentation explicite dans la classe Teacher.
public interface IEmployee
{
    string EmployeeId { get; }

    void DisplayInfo();
}
