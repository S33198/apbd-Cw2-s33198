namespace ConsoleApp2;

public class Camera : Device
{
    public int CameraLensSize { get; set; } //mm
    public int LensFocalLenght { get; set; }
    public Camera(string name, int producentID, float price,  int cameralenssize, int lensfocallenght) : base(name, producentID, price)
    {
        this.LensFocalLenght = lensfocallenght;
        this.CameraLensSize = cameralenssize;
    }
}