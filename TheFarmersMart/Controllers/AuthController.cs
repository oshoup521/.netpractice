using System.Diagnostics;
using System.Text.Json;
using formUser;
using Microsoft.AspNetCore.Mvc;
using TheFarmersMart.Models;

namespace TheFarmersMart.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public AuthController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Validate(){
        
        return Redirect("welcome");
    }

    public IActionResult Signup()
    {
        return View();
    }

    public IActionResult NewUser(string name,string username,string email,string pwd,string confirmpwd){
        var user = new User(name,username,email,pwd,confirmpwd);
        List<User> users = new List<User>();
        users.Add(user);
        try
        {
            //serialization
            var options=new JsonSerializerOptions {IncludeFields=true};
            var usersJson=JsonSerializer.Serialize<List<User>>(users,options);
            string fileName=@"E:\local repository\.netpractice\TheFarmersMart\Models\storage.json";
            System.IO.File.WriteAllText(fileName,usersJson);


            //deserialization
            string jsonString=System.IO.File.ReadAllText(fileName);
            List<User> jsonUsers = JsonSerializer.Deserialize<List<User>>(jsonString);
            
        }
        catch (System.Exception)
        {
            
            throw;
        }
        
        return  Redirect("Welcome");
    }

    public IActionResult Welcome()
    {
        return View();
    }


     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}