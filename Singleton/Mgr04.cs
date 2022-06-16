namespace Singleton;

// Lazy loading, by default thread safe
public class Mgr04
{
    private static int counter = 0;

    private Mgr04()
    {
        counter++;
        Console.WriteLine("Counter Value: " + counter);
    }

    private static readonly Lazy<Mgr04> InstanceLock = new(() => new Mgr04());

    public static Mgr04 GetInstance => InstanceLock.Value;

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}