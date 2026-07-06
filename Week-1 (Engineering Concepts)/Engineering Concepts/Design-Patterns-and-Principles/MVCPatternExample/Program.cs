using System;

class Program
{
    static void Main(string[] args)
    {
        Student student =
            new Student("Salmali", 101, "A");

        StudentView view = new StudentView();

        StudentController controller =
            new StudentController(student, view);

        Console.WriteLine("Initial Student Record:");
        controller.UpdateView();

        controller.SetStudentName("Salmali Chattopadhyay");
        controller.SetStudentGrade("A+");

        Console.WriteLine("Updated Student Record:");
        controller.UpdateView();
    }
}