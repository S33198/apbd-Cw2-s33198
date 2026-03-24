namespace ConsoleApp2;

public abstract class Device
{
    static int counter = 1;
    public String name { get; set; }
    public bool status { get; set; } //dostepnosc
    public int id { get; set; } = counter++;
    public int producerID {get; set;}
    public float price { get; set; }
    

    public Device(string name, int producerid, float price)
    {
        this.name = name;
        producerID = producerid;
        this.price = price;
        status = true;
        id = counter++;
    }

    public void ChangeStatus()
    {
        status = !status;
    }
    
}