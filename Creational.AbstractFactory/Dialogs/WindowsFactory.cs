
using Creational.AbstractFactory.Components;

namespace Creational.AbstractFactory.Dialogs
{
    public class WindowsFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
