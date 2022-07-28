public class Image
{
    private string id;
    private string name;
    private string type;
    private string uri;
    private string size;
    private string createdAt;
    private string updatedAt;

    public Image(string id, string name, string type, string uri, string size, string createdAt, string updatedAt)
    {
        this.id = id;
        this.name = name;
        this.type = type;
        this.uri = uri;
        this.size = size;
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

    public string Type
    {
        get { return type; }
    }

    public string Uri
    {
        get { return uri; }
    }

    public string Size
    {
        get { return size; }
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