
namespace Creational.FactoryPattern.Models
{
    //Concrete Product
    public class WindowsButton : IButton
    {
        public string Render()
        {
            return "WindowsButton Render Method";
        }
    }
}
