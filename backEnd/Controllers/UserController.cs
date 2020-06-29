using System;
using System.Threading.Tasks;
using backEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("v1/[controller]")]
public class UserController : Controller
{
    public UserController(UserService service)
    {
        this.Service = service;
    }

    public UserService Service { get; }

    [HttpPost]
    [Route("login")]
    [AllowAnonymous]
    public async Task<ActionResult<dynamic>> Login([FromBody] User user)
    {
        return await Service.Authenticate(user); ;
    }

    [HttpPost]
    [Route("signUp")]
    [AllowAnonymous]
    public async Task<ActionResult<dynamic>> SignUp([FromBody] User user)
    {
        var newUser = await Service.SignUpAsync(user);
        if (newUser == null) return new StatusCodeResult(406); //  request.CreateResponse(HttpStatusCode.NotAcceptable, user);
        return newUser;
    }

    [HttpGet]
    [Route("authenticated")]
    [Authorize]
    public string Authenticated() => String.Format($"Autenticado - {User.Identity.Name}");

    [HttpGet]
    [Route("Role")]
    [Authorize(Roles = "User")]
    public string Manager() => "User";
}