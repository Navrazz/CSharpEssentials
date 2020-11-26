using Creational.AbstractFactory.Components;
using Creational.AbstractFactory.Dialogs;
using System;

namespace Creational.AbstractFactory
{
    public class Client
    {
        private IGuiFactory _guiFactory;

        public void Initialize()
        {
            string env = "Windows";

            if (env == "Windows")
            {
                _guiFactory = new WindowsFactory();
            }
            else if (env == "Web")
            {
                _guiFactory = new WebFactory();
            }

            else
            {
                throw new Exception("Unknown enviorment");
            }
        }

        public string Run()
        {
            IButton button = _guiFactory.CreateButton();
            ICheckbox checkbox = _guiFactory.CreateCheckbox();

            return button.Render() +" / "+ checkbox.Render();
        }
    }
}
