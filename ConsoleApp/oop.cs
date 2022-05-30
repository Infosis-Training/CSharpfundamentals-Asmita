
// 1-classes and objects
using System;
// defining class
class Person
{
    // members: fields,methods
    // fields
    internal static string scientificName;
    public string personName;
    public float heightInFt;
    public byte age;
    public string gender;

    //methods
    public void SpeakLanguage() 
    {
        Console.WriteLine(personName + " is speaking");
    }
    
    public string GetPersonDetails()
    {

        string nameDesc = "I am " + personName;
        string heightDesc = "My height is " + heightInFt+ "Ft";
        string ageDesc = "I am " + gender;
        string personDesc = nameDesc + "\n" + heightDesc + "\n"+ ageDesc;
        return personDesc;

    }


}