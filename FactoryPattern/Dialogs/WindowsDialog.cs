using FactoryPattern.Models;

namespace FactoryPattern.Dialogs
{
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
