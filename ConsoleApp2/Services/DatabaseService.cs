using ConsoleApp2.DataBase;

namespace ConsoleApp2.Services;

public class DatabaseService : IDatabaseService
{
    public static void Status()
    {
        int ActiveRents = 0;
        int DelayedRents = 0;
        foreach (Rent rent in Database.rents)
        {
            if (rent.Active)
                ActiveRents++;
            if((rent.RentDate.AddDays(rent.RentTime))< DateTime.Now)
                DelayedRents++;
        }

        float price = 0;
        foreach (Device device in Database.devices)
        {
            price+=device.price;
        }
        Console.WriteLine("Active Rents: "+ActiveRents);
        Console.WriteLine("Delayed Rents: "+DelayedRents);
        Console.WriteLine("Price for all devices: "+price);
    }
}