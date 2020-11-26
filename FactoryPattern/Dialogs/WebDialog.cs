using Creational.FactoryPattern.Models;

namespace Creational.FactoryPattern.Dialogs
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
