using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController
{
    public UserController(UserService service)
    {
        this.Service = service;
    }

    public UserService Service { get; }
}