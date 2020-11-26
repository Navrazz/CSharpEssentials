using Creational.FactoryPattern.Models;

namespace Creational.FactoryPattern.Dialogs
{
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
