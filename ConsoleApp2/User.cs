namespace ConsoleApp2;

public abstract class User
{
    private int counter = 0;
    private int id;
    protected String name;
    protected String surname;
    protected User(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
}