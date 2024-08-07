using DotnetBackendPoc.Services;
using Microsoft.AspNetCore.Mvc;
using DotnetBackendPoc.Moduels;
using System.Text.Json;
namespace DotnetBackendPoc.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<ICalculator> _logger;

    public CalculatorController(ILogger<ICalculator> logger)
    {
        _logger = logger;
    }


    [HttpGet("add/{x}/{y}")]
    public int Add(int x, int y)
    {
        _logger.LogInformation($"{x} plus {y} is {x + y}");
        return x + y;
    }

    [HttpGet("naveen")]
    public string Subtract(int x, int y)
    {
        _logger.LogInformation($"{x} subtract {y} is {x - y}");
        var result = new Result
        {
            Name = "Naveen",
            Email = "nk@gmail.com"
        };

        var apiResponse = new ApiResponse
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
        _logger.LogInformation($"{apiResponse.StatusCode} {apiResponse.Message} {JsonSerializer.Serialize(apiResponse.Data)}");
        return "success";
    }
}