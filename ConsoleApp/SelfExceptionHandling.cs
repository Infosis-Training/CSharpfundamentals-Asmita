
using System;
// namespace CollegeException;
class CollegeH
{
    int stuAttendance=0;
    public int DetailsStudent(int Id, int studAttendance )
    {
        try
        {
            studAttendance=15;
            if (studAttendance<10)
            {
                throw new Exception("Cannot attend assesment");
            }
            return (studAttendance); 


        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return (studAttendance); 

        }
    }
    // public string Teacher(string Faculty, int Num)
    // {

    // }
}