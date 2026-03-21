namespace ConsoleApp2;

public abstract class device
{
    static int counter = 1;
    protected String name { get; set; }
    protected bool status { get; set; }
    protected int id { get; set; }
    protected int producentID {get; set;}
    protected float price { get; set; }

    protected device(string name, int producentId, float price)
    {
        this.name = name;
        producentID = producentId;
        this.price = price;
        status = false;
        id = counter++;
    }
}