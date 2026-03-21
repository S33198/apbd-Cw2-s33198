namespace ConsoleApp2;

public class Laptop : Device
{
    protected int RAM; //GB
    protected string CPU;
    protected double ScreenSize; //inches

    public Laptop(string name, int producentID, float price,  int ram, string cpu, double screenSize) : base(name, producentID, price)
    {
        this.RAM = ram;
        this.CPU = cpu;
        this.ScreenSize = screenSize;
    }
}