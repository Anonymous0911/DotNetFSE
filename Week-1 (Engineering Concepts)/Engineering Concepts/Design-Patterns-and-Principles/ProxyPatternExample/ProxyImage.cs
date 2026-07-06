public class ProxyImage : Image
{
    private RealImage? realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        // Lazy Initialization
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }

        // Cached object reused
        realImage.Display();
    }
}