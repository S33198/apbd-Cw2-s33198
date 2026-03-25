using ConsoleApp2.DataBase;
using ConsoleApp2.Exceptions;

namespace ConsoleApp2.Services;

public class Rentals
{ 
    public string ToString(Rent  rent)
    {
        return "RentID: " + rent.id.ToString() + " DeviceID: " + rent.deviceID.ToString() + " UserID: " + rent.RenterID.ToString() + " Rent date: " + rent.RentDate;
    }
    public bool GetStatus(Rent rent)
    {
        return rent.Active;
    }
    public static bool IsDelayed(Rent rent)
    {
        return (DateTime.Now - rent.RentDate).TotalDays > rent.RentTime;
    }
}