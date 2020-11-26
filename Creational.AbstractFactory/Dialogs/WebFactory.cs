
using Creational.AbstractFactory.Components;

namespace Creational.AbstractFactory.Dialogs
{
    public class WebFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new HtmlButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new HtmlCheckbox();
        }
    }
}
