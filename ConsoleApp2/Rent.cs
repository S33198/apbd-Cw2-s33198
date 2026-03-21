namespace ConsoleApp2;

public class Rent
{
    private int PenaltyForDay = 100;
    static int count = 1;
    private int RenterID;//kto wypozyczyl
    private int RentTime;//Dni
    private bool ReturnInTime;
    private int deviceID;
    private DateTime RentDate;
    private DateTime ReturnDate;

    public Rent(int rentTime, int deviceId, User user)
    {
        RentDate = DateTime.Now;
        RenterID = user.id;
        RentTime = rentTime;
        deviceID = deviceId;
        ReturnInTime = false;
    }

    public void ReturnRent()
    {
        ReturnDate = DateTime.Now;
        int Days=(ReturnDate - RentDate).Days;
        ReturnInTime = (Days <= RentTime);
        if (!ReturnInTime)
            ConsoleApp2.users[RenterID-1].AddPenalty(PenaltyForDay*(Days-RentTime));
    }
    
    
}
