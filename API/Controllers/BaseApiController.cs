using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")] // localhost:5001 /api/<nazwa_kontrolera>
public class BaseApiController : ControllerBase
{

}
