using ConsoleApp2.DataBase;
using ConsoleApp2.Services;

namespace ConsoleApp2;

public class test
{
    public static void Main(String[] args)
    {
        Database.users.Add(new Student("Hubert", "Binienda"));
        Database.users.Add(new Student("Adam", "Malysz"));
        Database.users.Add(new Student("Alexander", "Malysz"));
        Database.users.Add(new Student("Kamil", "Stoch"));
        Database.devices.Add(new Laptop("dell", 1, 4200, 16, "I7", 15.6));
        Database.devices.Add(new Laptop("asus", 1, 4500, 32, "I7", 13));
        Database.devices.Add(new Laptop("asus", 1, 4500, 32, "I7", 13));
        Database.devices.Add(new Projector("asus", 1, 4500, 32, "3092x4096", 60));
        RentDevice.Rent(5, 2, 1);
        RentDevice.Rent(5, 3, 1);
        RentDevice.Rent(5, 4, 2);
        //RentDevice.Rent(5, 2, 2); // To wyrzuca blad
        ReturnRent.Return(1, new DateTime(2027, 03, 24));
        ReturnRent.Return(2, DateTime.Now);
        ShowDelayedRents.showdelayedrents();
        ShowRentsForUser.ShowRentForUser(2);
        DatabaseService.Status();


    }
}