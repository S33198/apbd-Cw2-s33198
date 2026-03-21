namespace ConsoleApp2;

public class Rent
{
    static int count = 1;
    private int RenterID;//kto wypozyczyl
    private int RentTime;//Dni
    private bool ReturnInTime;
    private int deviceID;
    private DateTime RentDate;
    private DateTime ReturnDate;

    public Rent(int renterId, int rentTime, int deviceId)
    {
        RentDate = DateTime.Now;
        RenterID = renterId;
        RentTime = rentTime;
        deviceID = deviceId;
        ReturnInTime = false;
    }

    public void ReturnRent()
    {
        ReturnDate = DateTime.Now;
        int Days=(ReturnDate - RentDate).Days;
        ReturnInTime = (Days <= RentTime);
        /*if (!ReturnInTime)
        {
            
        }*/
    }
    
    
}
