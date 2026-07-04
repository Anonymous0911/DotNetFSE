using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;
// using EmployeeAPI.Filters;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles="Admin,POC")]
// [CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new List<Employee>
    {
        new Employee
        {
            Id = 1,
            Name = "Rahul",
            Salary = 50000,
            Permanent = true,
            Department = new Department
            {
                Id = 1,
                Name = "IT"
            },
            Skills = new List<Skill>
            {
                new Skill
                {
                    Id = 1,
                    Name = "C#"
                },
                new Skill
                {
                    Id = 2,
                    Name = ".NET"
                }
            },
            DateOfBirth = new DateTime(1999,5,12)
        },

        new Employee
        {
            Id = 2,
            Name = "Ankit",
            Salary = 60000,
            Permanent = false,
            Department = new Department
            {
                Id = 2,
                Name = "HR"
            },
            Skills = new List<Skill>
            {
                new Skill
                {
                    Id = 3,
                    Name = "Java"
                }
            },
            DateOfBirth = new DateTime(1998,8,10)
        }
    };

    // GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    // GET BY ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> Get(int id)
    {
        if (id <= 0)
            return BadRequest("Invalid employee id");

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return BadRequest("Invalid employee id");

        return Ok(employee);
    }

    // POST
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);

        return Ok(employee);
    }

    // PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

        if (existingEmployee == null)
        {
            return BadRequest("Invalid employee id");
        }

        existingEmployee.Name = employee.Name;
        existingEmployee.Salary = employee.Salary;
        existingEmployee.Permanent = employee.Permanent;
        existingEmployee.Department = employee.Department;
        existingEmployee.Skills = employee.Skills;
        existingEmployee.DateOfBirth = employee.DateOfBirth;

        return Ok(existingEmployee);
    }

    // DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Delete(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        employees.Remove(employee);

        return Ok("Employee Deleted Successfully");
    }
}