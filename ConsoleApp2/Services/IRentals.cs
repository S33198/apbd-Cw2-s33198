namespace ConsoleApp2.Services;

public interface IRentals
{
    public void RentDevice(int rentTime, int deviceId, int userId);
    public void ReturnDevice(int RentId);
    public void ShowRentsForUser(int userId);
    public void ShowDelayedRents();
    
}