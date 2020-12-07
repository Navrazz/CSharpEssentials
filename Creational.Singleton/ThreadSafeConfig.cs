
namespace Creational.Singleton
{
    public class ThreadSafeConfig
    {
        private string _appPath;
        private static ThreadSafeConfig _config;

        private static readonly object _lock = new object();

        private ThreadSafeConfig(string path)
        {
            _appPath = path;
        }

        public static ThreadSafeConfig GetInstance(string path)
        {
            if (_config == null)
            {

            lock(_lock)
                { 
                    if (_config == null)
                    { 
                        _config = new ThreadSafeConfig(path);
                    }
                }
            }

            return _config;
        }

        public string GetPath()
        {
            return _appPath;
        }
    }
}
