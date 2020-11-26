
namespace FactoryPattern.Models
{
    public class HtmlButton : IButton
    {
        public string Render()
        {
            return "HtmlButton Render Method";
        }
    }
}
