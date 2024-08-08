// using DotnetBackendPoc.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
// using DotnetBackendPoc.Moduels;
namespace DotnetBackendPoc.Controllers;


[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{

    [HttpGet("add/{x}/{y}")]
    [Authorize]
    public int Add(int x, int y)
    {
        return x + y;
    }

    [HttpGet]
    [Authorize]
    [Route("naveen")]
    public string Subtract()
    {
        return "Hello word";
    }
}