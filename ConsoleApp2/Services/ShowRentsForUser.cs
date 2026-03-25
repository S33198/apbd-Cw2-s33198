namespace ConsoleApp2.Services;
using ConsoleApp2.DataBase;
public class ShowRentsForUser
{
    public static void ShowRentForUser(int userid)
    {
        Console.WriteLine("Active rents for user: " + userid);
        foreach (Rent rent in Database.rents)
        {
            if(rent.Active && rent.RenterID == userid)
                Console.WriteLine(rent);
        }
    }
}