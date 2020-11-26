
namespace Creational.FactoryPattern.Models
{
    //Concrete Product
    public class HtmlButton : IButton
    {
        public string Render()
        {
            return "HtmlButton Render Method";
        }
    }
}
