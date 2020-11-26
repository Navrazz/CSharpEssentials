using Creational.FactoryPattern.Models;

namespace Creational.FactoryPattern.Dialogs
{
    //Creator
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public string RenderButton()
        {
            var button = CreateButton();
            var result = button.Render();

            return result;
        }
    }
}
