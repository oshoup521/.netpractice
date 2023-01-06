using System.Text.RegularExpressions;

namespace Membership;

public static class AuthManager
{
    //Regex rg = new Regex(pattern);
    public static bool Validate(string name, string email)
    {
        bool status = false;
        bool isEmail = Regex.IsMatch(
            email,
            @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            RegexOptions.IgnoreCase
        );
        bool isName = Regex.IsMatch(name, @"^[A-Z][a-zA-Z]*$");
        if (isName && isEmail)
        {
            status = true;
        }
        return status;
    }

    public static bool Register(
        string firstName,
        string lastName,
        string location,
        string contactNumber,
        string email
    )
    {
        bool status = false;
        try
        {
            User newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.ContactNumber = contactNumber;
            newUser.Email = email;
            newUser.Location = location;
            status = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("inside Exception");
        }
        return status;
    }
}
