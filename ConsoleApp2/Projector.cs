namespace ConsoleApp2;

public class Projector : device
{
    protected int luminance { get; set; }
    protected string resolution { get; set; }
    protected int Hz { get; set; }
    public Projector(string name, int producentID, float price,  int luminance, string resolution, int hz) : base(name, producentID, price)
    {
        this.luminance = luminance;
        this.resolution = resolution;
        this.Hz = hz;
    }
}