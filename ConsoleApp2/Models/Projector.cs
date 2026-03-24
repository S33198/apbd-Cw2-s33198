namespace ConsoleApp2;

public class Projector : Device
{
    public int luminance { get; set; }
    public string resolution { get; set; }
    public int Hz { get; set; }
    public Projector(string name, int producentID, float price,  int luminance, string resolution, int hz) : base(name, producentID, price)
    {
        this.luminance = luminance;
        this.resolution = resolution;
        this.Hz = hz;
    }
}