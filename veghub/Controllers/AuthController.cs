using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using veghub.Models;
using formUser;

namespace veghub.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Validate(string email, string pwd)
    {
        User u1 = new User();
        List<User> data = u1.RetreiveData();
        User tempuser = new User(email, pwd);
        foreach (User u in data){
            if(u.Email==email && u.Pwd==pwd){
               
                return Redirect("Welcome");
            } 
        }
        return Redirect("Error");
    }

    public IActionResult NewUser(string name, string email, string pwd, string confirmpwd)
    {
        User u = new User();
        List<User> users = u.RetreiveData();
        User newUser = new User(name, email, pwd, confirmpwd);
        users.Add(newUser);
        u.StoreData(users);
        return Redirect("Welcome");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
