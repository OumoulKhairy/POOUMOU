using Interfaces_M1;

// Tâche 5 : démonstration
Student student = new Student("Awa Ndiaye", 22, "Computer Science");
Teacher teacher = new Teacher("Moussa Diallo", 45, "Mathematics", "T-1024");

Console.WriteLine("--- Polymorphism: a list of IPerson ---");
List<IPerson> people = new List<IPerson> { student, teacher };

foreach (IPerson person in people)
{
    person.DisplayInfo();   // chaque classe applique SON comportement
}

Console.WriteLine();
Console.WriteLine("--- Explicit implementation ---");

student.DisplayInfo();      // OK : implémentation implicite (publique)
// teacher.DisplayInfo();   // ERREUR de compilation : implémentation explicite

IPerson teacherAsPerson = teacher;
IEmployee teacherAsEmployee = teacher;

teacherAsPerson.DisplayInfo();     // version IPerson
teacherAsEmployee.DisplayInfo();   // version IEmployee

Console.WriteLine();

// Tâche 6 : tests
Console.WriteLine("--- Tests ---");
int passed = 0;
int total = 0;

void Check(string testName, bool condition)
{
    total++;
    if (condition) passed++;
    Console.WriteLine($"{(condition ? "PASS" : "FAIL")} - {testName}");
}

Check("Student implements IPerson", typeof(IPerson).IsAssignableFrom(typeof(Student)));
Check("Teacher implements IPerson", typeof(IPerson).IsAssignableFrom(typeof(Teacher)));
Check("Teacher implements IEmployee", typeof(IEmployee).IsAssignableFrom(typeof(Teacher)));
Check("Student does not implement IEmployee", !typeof(IEmployee).IsAssignableFrom(typeof(Student)));

IPerson p = student;
p.Name = "Awa Fall";
Check("Setting Name through the interface updates the object", student.Name == "Awa Fall");

p.Age = 23;
Check("Setting Age through the interface updates the object", student.Age == 23);

IEmployee? employee = teacher as IEmployee;
Check("Casting Teacher with 'as' returns an IEmployee", employee != null && employee.EmployeeId == "T-1024");

IEmployee? notEmployee = student as IEmployee;
Check("Casting Student with 'as' returns null", notEmployee == null);

Check("The list holds 2 people", people.Count == 2);

Console.WriteLine($"\n{passed}/{total} tests passed.");
