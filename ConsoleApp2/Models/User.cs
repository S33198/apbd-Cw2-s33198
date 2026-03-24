namespace ConsoleApp2;

public abstract class User
{
    private int counter = 0;
    public int Penalty {get; set;}
    public int id { get; }
    protected String name;
    protected String surname;
    protected User(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        Penalty = 0;
    }
    
    

    
}