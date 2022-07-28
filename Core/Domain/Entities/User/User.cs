public class User
{
    private string id;
    private string name;
    private string email;
    private string password;
    private string createdAt;
    private string updatedAt;

    public User(string id, string name, string email, string password, string createdAt, string updatedAt)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.createdAt = createdAt ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        this.updatedAt = updatedAt ?? "";
    }
    
    public string Id
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
    }

    public string Email
    {
        get { return email; }
    }

    public string Password
    {
        get { return password; }
    }

    public string CreatedAt
    {
        get { return createdAt; }
    }

    public string UpdatedAt
    {
        get { return updatedAt; }
    }
}