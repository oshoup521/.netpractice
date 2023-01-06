namespace formUser;

class User{
    public string Name{get;set;}
    public string Username{get;set;}
    public string Email{get;set;}
    public  string Pwd{get;set;}
    public string Confirmpwd{get;set;}

    public User(string name,string username,string email,string pwd,string confirmpwd){
        this.Name=name;
        this.Username=username;
        this.Email=email;
        this.Pwd=pwd;
        this.Confirmpwd=confirmpwd;
    }

}