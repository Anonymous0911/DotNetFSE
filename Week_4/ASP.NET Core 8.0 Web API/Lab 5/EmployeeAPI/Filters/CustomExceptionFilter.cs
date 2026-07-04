using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeAPI.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        File.AppendAllText(
            "ErrorLog.txt",
            DateTime.Now +
            "\n" +
            context.Exception.ToString() +
            "\n\n");

        context.Result = new ObjectResult("Internal Server Error")
        {
            StatusCode = 500
        };

        context.ExceptionHandled = true;
    }
}