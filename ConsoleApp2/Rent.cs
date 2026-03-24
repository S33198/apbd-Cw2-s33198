namespace ConsoleApp2;

public class Rent
{
    private int RentID;
    private int PenaltyForDay = 100;
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
        RentID = count++;
        RentDate = DateTime.Now;
        RenterID = user.id;
        RentTime = rentTime;
        deviceID = deviceId;
        ReturnInTime = false;
        Active = true;
    }

    public void ReturnRent()
    {
        ReturnDate = DateTime.Now;
        int Days=(ReturnDate - RentDate).Days;
        ReturnInTime = (Days <= RentTime);
        if (!ReturnInTime)
            ConsoleApp2.users[RenterID-1].AddPenalty(PenaltyForDay*(Days-RentTime));
        Active = false;
    }

    public void ShowRent(List<Rent> rents, User user)
    {
        foreach (Rent rent in rents)
        {
            if(rent.Active && rent.RenterID == user.id)
                Console.WriteLine(rent);
        }
    }

    public override string ToString()
    {
        return "RentID: " + RentID.ToString() + " DeviceID: " + deviceID.ToString() + " UserID: " + RenterID.ToString() + " Rent date: " + RentDate;
    }
    
}
