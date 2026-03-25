using ConsoleApp2.DataBase;
using ConsoleApp2.Exceptions;
namespace ConsoleApp2.Services;

public class RentDevice
{
    public static void Rent(int rentTime, int deviceId, int userid)
    {
        User user = new Student("nieznany", "uzytkownik");
        foreach(User temp in Database.users)
            if(temp.id == userid)
                user = temp;
        Rent rent = new Rent(rentTime, deviceId, user.id);
        int RentsAmount = 0;
        foreach (Rent rents in Database.rents)
        {
            if(rents.RenterID == user.id && rents.Active)
                RentsAmount++;
        }
        if((RentsAmount > Settings.RentsLimitForStudent && user.GetType() == typeof(Student)) || 
           (RentsAmount > Settings.RentsLimitForEmployee && user.GetType() == typeof(Employee)))
            throw new RentsLimitException(user.id);
        foreach(Device device in Database.devices)
            if(device.id == deviceId)
                if(device.status)
                    device.ChangeStatus();
                else
                    throw new DeviceIsRented();
        Database.rents.Add(rent);
    }
}