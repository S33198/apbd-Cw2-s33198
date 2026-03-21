namespace ConsoleApp2;

public abstract class Device
{
    static int counter = 1;
    protected String name { get; set; }
    protected bool status { get; set; }
    protected int id { get; set; }
    protected int producentID {get; set;}
    protected float price { get; set; }

    protected Device(string name, int producentId, float price)
    {
        this.name = name;
        producentID = producentId;
        this.price = price;
        status = false;
        id = counter++;
    }
    
    public void PrintAvailableDevices(Device[] devices)
    {
        Console.WriteLine("Available devices:");
        foreach (Device device in devices)
            {
            if (device.status)
                Console.WriteLine(device);
            }
    }
}