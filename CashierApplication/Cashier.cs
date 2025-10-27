public class Cashier : UserAccount
{
    private readonly string department;

    public Cashier(string fullName, string department, string userName, string userPassword)
    {
        this.full_name = fullName;
        this.department = department;
        this.user_name = userName;
        this.user_password = userPassword;
    }

    public override bool ValidateLogin(string uName, string password)
    {
        return user_name == uName && user_password == password;
    }

    public string GetDepartment()
    {
        return department;
    }
}
