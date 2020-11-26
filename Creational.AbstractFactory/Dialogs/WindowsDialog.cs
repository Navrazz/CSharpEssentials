using Creational.AbstractFactory.Components;

namespace Creational.AbstractFactory.Dialogs
{
    public class WindowsDialog : IDialog
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
