using Creational.FactoryPattern.Models;

namespace Creational.FactoryPattern.Dialogs
{
    //Concrete Creator
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
