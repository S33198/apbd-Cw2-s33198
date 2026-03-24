namespace ConsoleApp2;

public class Rent
{
    private int RentID;
    
    static int count = 1;
    private int RenterID;//kto wypozyczyl
    private int RentTime;//Dni
    private bool ReturnInTime;
    private int deviceID;
    private DateTime RentDate;
    private DateTime ReturnDate;
    private bool Active;

    public Rent(int rentTime, int deviceId, User user)
    {
        int RentsAmount = 0;
        foreach (Rent rents in ConsoleApp2.rents)
        {
            if(rents.RenterID == user.id && rents.Active)
                RentsAmount++;
        }
        if((RentsAmount > ConsoleApp2.RentsLimitForStudent && user.GetType() == typeof(Student)) || 
           (RentsAmount > ConsoleApp2.RentsLimitForEmployee && user.GetType() == typeof(Employee)))
            throw new Exception("Reached maximum amount of rents");
        RentID = count++;
        RentDate = DateTime.Now;
        RenterID = user.id;
        RentTime = rentTime;
        deviceID = deviceId;
        ReturnInTime = false;
        Active = true;
        foreach(Device device in ConsoleApp2.devices)
            if(device.GetID() == deviceID)
                if(device.GetStatus())
                    device.ChangeStatus();
                else
                    throw new Exception("Device is unavailable");
    }

    public void ReturnRent()
    {
        ReturnDate = DateTime.Now;
        int Days=(ReturnDate - RentDate).Days;
        ReturnInTime = (Days <= RentTime);
        if (!ReturnInTime)
            ConsoleApp2.users[RenterID-1].AddPenalty(ConsoleApp2.PenaltyForDay*(Days-RentTime));
        Active = false;
        foreach(Device device in ConsoleApp2.devices)
            if(device.GetID() == deviceID)
                    device.ChangeStatus();
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
            if (rent.IsDelayed())
            {
                Console.WriteLine(rent);
            }
        }
    }

    public override string ToString()
    {
        return "RentID: " + RentID.ToString() + " DeviceID: " + deviceID.ToString() + " UserID: " + RenterID.ToString() + " Rent date: " + RentDate;
    }
    public bool GetStatus()
    {
        return Active;
    }
    
    public bool IsDelayed()
    {
        return (DateTime.Now - RentDate).TotalDays > RentTime;
    }
    
}
