namespace ConsoleApp2;

public abstract class device
{
    static int counter = 1;
    protected String name { get; set; }
    protected bool status { get; set; }
    protected int id { get; set; }
    protected String producentID {get; set;}
    protected int price { get; set; }
}