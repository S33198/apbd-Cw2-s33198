namespace ConsoleApp2;

public class Camera : device
{
    protected int CameraLensSize; //mm
    protected int LensFocalLenght;
    public Camera(string name, int producentID, float price,  int cameralenssize, int lensfocallenght) : base(name, producentID, price)
    {
        this.LensFocalLenght = lensfocallenght;
        this.CameraLensSize = cameralenssize;
    }
}