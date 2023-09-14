using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;

namespace TddReference.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class LibraryController : ControllerBase
{
    private readonly ILogger<LibraryController> _logger;

    public LibraryController(ILogger<LibraryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSchedule")]
    public IEnumerable<DaySchedule> GetSchedule()
    {
        var result = new DaySchedule[1];
        result[0] = new DaySchedule();

        return result;

    }
}