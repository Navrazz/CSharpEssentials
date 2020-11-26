using Creational.FactoryPattern.Models;

namespace Creational.FactoryPattern.Dialogs
{
    //Concrete Creator
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
