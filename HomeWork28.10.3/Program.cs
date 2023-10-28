class Store
{
    private string name;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string ProfileDescription
    {
        get { return profileDescription; }
        set { profileDescription = value; }
    }
    public string ContactPhone
    {
        get { return contactPhone; }
        set { contactPhone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public void EnterData()
    {
        System.Console.Write("Enter the name of the store: ");
        Name = Console.ReadLine();
        System.Console.Write("Enter the address of the store: ");
        Address = Console.ReadLine();
        System.Console.Write("Enter the profile description of the store: ");
        ProfileDescription = Console.ReadLine();
        System.Console.Write("Enter the contact phone: ");
        ContactPhone = Console.ReadLine();
        System.Console.Write("Enter the email: ");
        Email = Console.ReadLine();
        System.Console.WriteLine();
    }
    public void DisplayData()
    {
        System.Console.WriteLine("Store Information:");
        System.Console.WriteLine("Name: " + Name);
        System.Console.WriteLine("Address: " + Address);
        System.Console.WriteLine("Profile Description: " + ProfileDescription);
        System.Console.WriteLine("Contact Phone: " + ContactPhone);
        System.Console.WriteLine("Email: " + Email);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();
        store.EnterData();
        store.DisplayData();
    }
}