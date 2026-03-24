namespace ConsoleApp2;

public class Laptop : Device
{
    public int RAM { get; set; } //GB
    public string CPU { get; set; }
    public double ScreenSize { get; set; } //inches

    public Laptop(string name, int producentID, float price,  int ram, string cpu, double screenSize) : base(name, producentID, price)
    {
        this.RAM = ram;
        this.CPU = cpu;
        this.ScreenSize = screenSize;
    }
}