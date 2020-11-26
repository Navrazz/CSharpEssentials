using FactoryPattern.Models;

namespace FactoryPattern.Dialogs
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
