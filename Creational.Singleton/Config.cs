
namespace Creational.Singleton
{
    public class Config
    {
        private static Config _config;

        string _appPath;

        private Config()
        {
            _appPath = @"C:\Dev\Path"; 
        }

        public static Config GetInstance()
        {
            if (_config == null)
            {
                _config = new Config();
            }

            return _config;
        }

        public string GetPath()
        {
            return _appPath;
        }
    }
}
