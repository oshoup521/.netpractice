// See https://aka.ms/new-console-template for more information

using Membership;
Console.WriteLine("Hello, World!");
string name="Rahul123";
string email="rahul1900@gamil.com";

if(AuthManager.Validate(name,email)){
    Console.WriteLine("sahi hai");
}
else{
    Console.WriteLine("galat hai");
}
// string firstName,
//         string lastName,
//         string location,
//         string contactNumber,
//         string email
AuthManager.Register("Rahul","Kumar","Mumbai","888777","rahul@gmail");
AuthManager.display();
