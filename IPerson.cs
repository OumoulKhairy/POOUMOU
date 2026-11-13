namespace Interfaces_M1;

// Tâche 2 : l'interface définit un CONTRAT (des signatures, pas de corps).
// Toute classe qui implémente IPerson doit fournir ces membres.
public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }

    void DisplayInfo();
}
