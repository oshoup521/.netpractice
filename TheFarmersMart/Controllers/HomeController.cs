using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheFarmersMart.Models;
using formUser;
using System.Text.Json;

namespace TheFarmersMart.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
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
            var options=new JsonSerializerOptions {IncludeFields=true};
            var usersJson=JsonSerializer.Serialize<List<User>>(users,options);
            string fileName=@"E:\local repository\.netpractice\TheFarmersMart\Models\storage.json";
            System.IO.File.AppendAllText(fileName,usersJson);
            string jsonString=System.IO.File.ReadAllText(fileName);
            List<User> jsonUsers = JsonSerializer.Deserialize<List<User>>(jsonString);
            Console.WriteLine("\n JSON :Deserializing data from json file\n\n");
            foreach (User newUser in jsonUsers)
            {
                Console.WriteLine($"{newUser.Name}:{newUser.Username}:{newUser.Email}:{newUser.Pwd}:{newUser.Confirmpwd}");
            }
        }
        catch (System.Exception)
        {
            
            throw;
        }
        
        return  View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
