using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    //OOP - Encapsulation**************
    private string name;
    private string studentID;
    private string contactNumber;
    private string email;

    public string Name { get { return name; } set { name = value; } }
    public string StudentID { get { return studentID; } set { studentID = value; } }
    public string ContactNumber { get { return contactNumber; } set { contactNumber = value; } }
    public string Email { get { return email; } set { email = value; } }

    public Student(string name, string studentId, string contactNumber, string email)
    {
        Name = name;
        StudentID = studentId;
        ContactNumber = contactNumber;
        Email = email;
    }
}
