using ConsoleApp2.DataBase;
using ConsoleApp2.Exceptions;
namespace ConsoleApp2.Services;

public class ReturnRent
{
    public static void Return(int rentid, DateTime returndate)
    {
        Rent? rent = null;
        foreach (Rent r in Database.rents)
        {
            if (r.id == rentid)
            {
                rent = r;
                break;
            }
        }
        if (rent == null)
            throw new RentNotFound();
        rent.ReturnDate = returndate;
        int Days=(rent.ReturnDate - rent.RentDate).Days;
        rent.ReturnInTime = (Days <= rent.RentTime);
        if (!rent.ReturnInTime)
            Database.users[rent.RenterID].Penalty+=Settings.PenaltyForDay*(Days-rent.RentTime);
        rent.Active = false;
        foreach(Device device in Database.devices)
            if(device.id == rent.deviceID)
                device.ChangeStatus();
    }
}