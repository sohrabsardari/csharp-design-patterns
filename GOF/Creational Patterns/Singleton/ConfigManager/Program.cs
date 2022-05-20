
using ConfigManager;

var configManager = NotThreadSafeConfigManager.GetInstance();

var threadSafeConfigManager = ThreadSafeConfigManager.GetInstance();