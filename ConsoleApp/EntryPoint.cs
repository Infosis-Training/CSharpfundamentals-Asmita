using OOP;
class EntryPoint
{
    public static void Main1()
    {
        // creating (instantiating) objects/instances
        Person p1 = new();
        // accessing static members
        Person.scientificName="HomoSapiens";
        // accessing instance members
        p1.personName = "Asmita";
        p1.heightInFt = 5.3f;
        p1.age = 24;
        p1.gender = "Female";
        string details = p1.GetPersonDetails();
        Console.WriteLine(details);
    }

}



