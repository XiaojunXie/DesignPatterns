namespace Singleton;

// not thread safe
public sealed class Mgr01
{
    private static Mgr01 instance = null;
    private static int counter = 0;
    private Mgr01()
    {
        counter++;
        Console.WriteLine("Counter Value " + counter.ToString());
    }
    public static Mgr01 GetInstance()
    {
        instance ??= new Mgr01();
        return instance;
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}