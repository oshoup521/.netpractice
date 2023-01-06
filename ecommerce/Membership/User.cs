namespace Membership;

public class User
{
    //normal property
    private string firstName;
    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string LastName { get; set; }
    public string Location { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }

    // public override string ToString()
    // {
    //     string str = string.Format("{0},{1},{2},{3}", firstName, LastName, ContactNumber, Email);
    //     return str;
    // }
}
