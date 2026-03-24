using ConsoleApp2.DataBase;
using ConsoleApp2.Exceptions;

namespace ConsoleApp2.Services;

public class Rentals
{
    public void RentDevice(int rentTime, int deviceId, User user)
    {
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

    public void ReturnRent(int rentid)
    {
        Rent rent = new Rent(0, 0, 0);
        foreach(Rent temp in Database.rents)
            if(temp.id == rentid)
                rent = temp;
        rent.ReturnDate = DateTime.Now;
        int Days=(rent.ReturnDate - rent.RentDate).Days;
        rent.ReturnInTime = (Days <= rent.RentTime);
        if (!rent.ReturnInTime)
            Database.users[rent.RenterID-1].Penalty+=Settings.PenaltyForDay*(Days-rent.RentTime);
        rent.Active = false;
        foreach(Device device in Database.devices)
            if(device.id == rent.deviceID)
                    device.ChangeStatus();
        foreach (Rent temp in Database.rents)
        {
            if (temp.id == rent.id)
                Database.rents.Remove(temp);
                Database.rents.Add(rent);
        }
    }

    public void ShowRentForUser(List<Rent> rents, User user)
    {
        foreach (Rent rent in rents)
        {
            Console.WriteLine("Active rents for user: " + user.id);
            if(rent.Active && rent.RenterID == user.id)
                Console.WriteLine(rent);
        }
    }

    public void ShowDelayedRents(List<Rent> rents)
    {
        foreach (Rent rent in rents)
        {
            Console.WriteLine("Delayed rents ");
            if (IsDelayed(rent))
            {
                Console.WriteLine(rent);
            }
        }
    }

    public string ToString(Rent  rent)
    {
        return "RentID: " + rent.id.ToString() + " DeviceID: " + rent.deviceID.ToString() + " UserID: " + rent.RenterID.ToString() + " Rent date: " + rent.RentDate;
    }
    public bool GetStatus(Rent rent)
    {
        return rent.Active;
    }
    
    public bool IsDelayed(Rent rent)
    {
        return (DateTime.Now - rent.RentDate).TotalDays > rent.RentTime;
    }
}