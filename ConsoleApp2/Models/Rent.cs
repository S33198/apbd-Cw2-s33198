namespace ConsoleApp2;

public class Rent(int renttime, int deviceid, int userid)
{
    
    private static int count = 1;
    public int RenterID { get; set; } = userid;//kto wypozyczyl
    public int RentTime { get; set; } = renttime;//Dni
    public bool ReturnInTime { get; set; } = true;
    public int deviceID { get; set; } = deviceid;
    public DateTime RentDate { get; set; } = DateTime.Now;
    public DateTime ReturnDate { get; set; } = DateTime.Now;
    public int id { get; set; } = count++;
    public bool Active { get; set; } = true;

    
}
