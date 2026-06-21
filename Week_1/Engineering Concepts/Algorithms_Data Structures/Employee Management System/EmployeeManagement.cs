using System;

public class EmployeeManagement
{
    private Employee[] employees;
    private int count;

    public EmployeeManagement(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    // Add Employee
    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;
            Console.WriteLine("Employee added successfully.");
        }
        else
        {
            Console.WriteLine("Array is full.");
        }
    }

    // Search Employee
    public Employee SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
                return employees[i];
        }

        return null;
    }

    // Traverse Employees
    public void TraverseEmployees()
    {
        Console.WriteLine("\nEmployee Records:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }

    // Delete Employee
    public void DeleteEmployee(int id)
    {
        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[count - 1] = null;
        count--;

        Console.WriteLine("Employee deleted successfully.");
    }
}