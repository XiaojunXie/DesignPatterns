namespace Singleton;

public class Mgr02
{
    private static int counter = 0;
    private static readonly object InstanceLock = new object();
    private static Mgr02 instance = null;

    private Mgr02()
    {
        counter++;
        Console.WriteLine("Count value: " + counter.ToString());
    }

    public static Mgr02 GetInstance
    {
        get
        {
            lock (InstanceLock)
            {
                return instance ?? (instance = new Mgr02());
            }
        }
        
    }
    
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}