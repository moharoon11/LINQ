

namespace LINQ.Models;

public class Student
{

    public int StudentID { get; set; }

    public string StudentName { get; set; } 

    public int Age { get; set; }

    
    public override string ToString()
    {
        return $"Student = [StudentID = {StudentID}, StudentName = {StudentName}, Age = {Age}]";
    }
}