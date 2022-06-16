// 饿汉式, 静态初始化
// 缺点 -- 不管用到与否，类装载时就完成实例化

namespace Singleton;

//  The advantage of using Eager Loading in the Singleton design pattern is that the CLR (Common Language Runtime) will take care of object initialization and thread-safety
public class Mgr03
{
    private static int counter = 0;

    private Mgr03()
    {
        counter++;
        Console.WriteLine("Counter Value: " + counter);
    }

    //  creates the Singleton instance at the time of application startup.
    private static readonly Mgr03 singleInstance = new Mgr03();

    public static Mgr03 GetInstance
    {
        get
        {
            return singleInstance;
        }
    }

    public void PrintDetails(string msg)
    {
        Console.WriteLine(msg);
    }
}