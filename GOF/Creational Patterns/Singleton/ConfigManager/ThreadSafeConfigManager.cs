namespace ConfigManager;

public class ThreadSafeConfigManager
{
    private static Lazy<ThreadSafeConfigManager> instance = new(()=> new ThreadSafeConfigManager(), true);
    private ThreadSafeConfigManager() {}

    public static ThreadSafeConfigManager GetInstance()
    {
        return instance.Value;
    }
}