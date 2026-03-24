using System.Diagnostics;

namespace ConsoleApp2;

public class ConsoleApp2
{
    public static List<User> users = new List<User>();
    public static List<Rent> rents = new List<Rent>();
    public static List<Device> devices = new List<Device>();
    public void Status()
    {
        int ActiveRents = 0;
        int DelayedRents = 0;
        foreach (Rent rent in rents)
        {
            if (rent.GetStatus())
                ActiveRents++;
            if(rent.IsDelayed())
                DelayedRents++;
        }

        float price = 0;
        foreach (Device device in devices)
        {
            price+=device.GetPrice();
        }
        Console.WriteLine("Active Rents: "+ActiveRents);
        Console.WriteLine("Delayed Rents: "+DelayedRents);
        Console.WriteLine("Price for all devices: "+price);
    }
    public static void Main(string[] args)
    {
        
        devices.Add(new Camera("sony", 32, 299, 12, 32));
        devices.Add(new Laptop("Dell", 31, 4200, 16, "wybitne", 20));
        Device.PrintAvailableDevices(devices);
    }
}