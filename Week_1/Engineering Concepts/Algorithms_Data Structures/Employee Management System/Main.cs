using System;

class Program
{
    static void Main()
    {
        EmployeeManagement em = new EmployeeManagement(5);

        em.AddEmployee(new Employee(101, "Aaquib", "Manager", 60000));
        em.AddEmployee(new Employee(102, "Rahul", "Developer", 50000));
        em.AddEmployee(new Employee(103, "Priya", "Analyst", 45000));

        em.TraverseEmployees();

        Employee result = em.SearchEmployee(102);

        if (result != null)
        {
            Console.WriteLine("\nEmployee Found:");
            Console.WriteLine(result);
        }

        em.DeleteEmployee(102);

        Console.WriteLine("\nAfter Deletion:");
        em.TraverseEmployees();
    }
}