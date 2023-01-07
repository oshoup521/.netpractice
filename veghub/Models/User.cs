
namespace formUser;
using System.Text.Json;


[Serializable]
public class User
{
    //public string fileName = @"E:\DotNetWorkspace\Day8\veghub\Models\storage.json";
    public string Name { get; set; }
    public string Email { get; set; }
    public string Pwd { get; set; }
    public string Confirmpwd { get; set; }

    public User() { }

    public User(string name, string email, string pwd, string confirmpwd)
    {
        this.Name = name;
        this.Email = email;
        this.Pwd = pwd;
        this.Confirmpwd = confirmpwd;
    }

    public User(string email, string pwd)
    {
        this.Email = email;
        this.Pwd = pwd;
    }

    public bool Equals(object? obj)
    {
        if (obj is User)
        {
            return this.Email.Equals(((User)obj).Email) && this.Pwd.Equals(((User)obj).Pwd);
        }

        return false;
    }

    public void StoreData(List<User> users)
    {
        string fileName = @"E:\DotNetWorkspace\Day8\veghub\Models\storage.json";
        var options = new JsonSerializerOptions { IncludeFields = true };
        var usersJson = JsonSerializer.Serialize<List<User>>(users, options);
        System.IO.File.WriteAllText(fileName, usersJson);
    }

    public List<User> RetreiveData()
    {
        string fileName = @"E:\DotNetWorkspace\Day8\veghub\Models\storage.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<User>? jsonusers = JsonSerializer.Deserialize<List<User>>(jsonString);
        return jsonusers;
    }
}
