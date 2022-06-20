# What is Singleton Pattern in C#?
We need to use the Singleton Design Pattern in C# when we need to ensures that only one instance of a particular class is going to be created and then provide simple global access to that instance for the entire application.

# Example
https://referencesource.microsoft.com/#mscorlib/system/threading/timer.cs,49

```c#
class TimerQueue
{
    #region singleton pattern implementation

    // The one-and-only TimerQueue for the AppDomain.
    static TimerQueue s_queue = new TimerQueue();

    public static TimerQueue Instance
    {
        get { return s_queue; }
    }

    private TimerQueue()
    {
        // empty private constructor to ensure we remain a singleton.
    }

    #endregion

    // ...
}
```