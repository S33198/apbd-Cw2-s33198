namespace ConsoleApp2;

public abstract class Device
{
    static int counter = 1;
    protected String name { get; set; }
    protected bool status { get; set; } //dostepnosc
    protected int id { get; set; }
    protected int producerID {get; set;}
    protected float price { get; set; }

    protected Device(string name, int producerid, float price)
    {
        this.name = name;
        producerID = producerid;
        this.price = price;
        status = true;
        id = counter++;
    }
    
    public static void PrintAvailableDevices(List<Device> devices)
    {
        Console.WriteLine("Available devices:");
        foreach (Device device in devices)
            {
            if (device.status)
                Console.WriteLine(device);
            }
    }

    public override string ToString()
    {
        return "Device type " + GetType().Name + ", Name: " + name + ", ProducerID: " + producerID + ", : " + price;
    }
    public void SetUnavailable()
    {
        status = false;
    }

    public float GetPrice()
    {
        return price;
    }
}