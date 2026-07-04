using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;
using EmployeeAPI.Filters;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
[HttpGet]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public ActionResult<List<Employee>> GetStandard()
{
    // throw new Exception("Demo Exception");
    return Ok(GetStandardEmployeeList());
    
}

    [HttpPost]
    public IActionResult Post(Employee employee)
    {
        return Ok(employee);
    }

    [HttpPut]
    public IActionResult Put(Employee employee)
    {
        return Ok(employee);
    }

    private List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id=1,
                Name="Rahul",
                Salary=50000,
                Permanent=true,

                Department=new Department
                {
                    Id=1,
                    Name="IT"
                },

                Skills=new List<Skill>
                {
                    new Skill
                    {
                        Id=1,
                        Name="C#"
                    },

                    new Skill
                    {
                        Id=2,
                        Name=".NET"
                    }
                },

                DateOfBirth=new DateTime(1999,5,12)
            }
        };
    }
}