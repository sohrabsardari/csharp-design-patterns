namespace ConfigManager;

public class NotThreadSafeConfigManager
{
    private static NotThreadSafeConfigManager instance;
    private NotThreadSafeConfigManager() {}

    /// <summary>
    /// It is not thread safe!!!!!!
    /// I prefer to not use lock and double check locking
    /// </summary>
    /// <returns></returns>
    public static NotThreadSafeConfigManager GetInstance()
    {
        if (instance == null)
        {
            instance = new NotThreadSafeConfigManager();
        }
        return instance;
    }

}