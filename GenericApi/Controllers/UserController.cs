using GenericApi.Interfaces;
using GenericApi.Models;
using GenericApi.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers;

public class UserController : Controller
{
    private readonly IUserService  _userService;

    public UserController(IUserService service)
    {
        _userService = service;
    }
    
    [HttpGet]
    [Route("")]
    public string Get()
    {
        return "Get";
    }

    [HttpPost]
    [Route("")]
    public async Task<string> Post([FromBody]User model)
    {
        try
        {
            var result = await this._userService.SaveUserAsync(model);
            return result;
        }
        catch (Exception ex)
        {
            return (ex.Message);
        }

     
    }
    
    [HttpPut]
    [Route("")]
    public string Put()
    {
        return "Put";
    }
    
    [HttpDelete]
    [Route("")]
    public string Delete()
    {
        return "Delete";
    }
    
    
}