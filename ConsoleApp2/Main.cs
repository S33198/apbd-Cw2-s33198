using System.Diagnostics;

namespace ConsoleApp2;

public class ConsoleApp2
{
    public static void Main(string[] args)
    {
        List<User> users = new List<User>();
        List<Rent> rents = new List<Rent>();
        List<Device> devices = new List<Device>();
        devices.Add(new Camera("sony", 32, 299, 12, 32));
        devices.Add(new Laptop("Dell", 31, 4200, 16, "wybitne", 20));
        Device.PrintAvailableDevices(devices);
    }
}