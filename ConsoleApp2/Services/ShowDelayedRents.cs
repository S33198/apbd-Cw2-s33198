using ConsoleApp2.DataBase;

namespace ConsoleApp2.Services;

public class ShowDelayedRents
{
    public static void showdelayedrents()
    {
        Console.WriteLine("Delayed rents ");
        foreach (Rent rent in Database.rents)
        {
            if (Rentals.IsDelayed(rent))
            {
                Console.WriteLine(rent);
            }
        }
    }
}