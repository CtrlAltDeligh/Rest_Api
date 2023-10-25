namespace Rest;

public class Student
{
    public Student()
    {
        
    }

    public Student(string studentId)
    {
        StudentId = studentId;
       
    }

    public string StudentId { get; private set; }
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;

    public string MiddleInital
    {
        get
        {
            return MiddleName.Substring(1)+".";
        }
    }
}