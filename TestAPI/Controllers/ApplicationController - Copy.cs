using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UsersController : ControllerBase {

    [HttpGet]
    public IActionResult GetAllUsers() {
        var users = new userDto[] {
            new (Guid.NewGuid(),"Abhay",true),
            new (Guid.NewGuid(),"Prince",true),
            new (Guid.NewGuid(),"Alex",false),
            new (Guid.NewGuid(),"Samantha",true),
            new (Guid.NewGuid(),"Krisha",false),
            new (Guid.NewGuid(),"Akshar",false),
        };
        return Ok(ApiResponse<UserDto[]>.Success(users));
    }
}
