using OOP;
namespace Object.Oriented;
// multiple:more than one parentclass which is not possible in csharp
// multilevel
// single
class Asian : Person
{

}
class African : Person
{

}
class Nepalese : Asian, ICulture
{
    public void SpeakLang()
    {

    }
}


interface ICulture
{
    void SpeakLang();
}
