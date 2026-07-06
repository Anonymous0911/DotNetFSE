using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    static List<Employee> employees = new()
    {
        new Employee
        {
            Id=1,
            Name="Rahul",
            Department="IT",
            Salary=45000
        },

        new Employee
        {
            Id=2,
            Name="Ankit",
            Department="HR",
            Salary=40000
        }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(employees);
    }

    [HttpPost]
    public IActionResult Post(Employee emp)
    {
        employees.Add(emp);

        return Ok("Employee Added Successfully");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Employee emp)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        employee.Name = emp.Name;
        employee.Department = emp.Department;
        employee.Salary = emp.Salary;

        return Ok("Employee Updated");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        employees.Remove(employee);

        return Ok("Employee Deleted");
    }
}