using System;
using FactoryPattern.Dialogs;

namespace FactoryPattern
{
    public class Client
    {
        private Dialog _dialog;

        public void Initialize()
        {
            string env = "Windows";

            if (env == "Windows")
            {
                _dialog = new WindowsDialog();
            }
            else if (env == "Web")
            {
                _dialog = new WebDialog();
            }

            else
            {
                throw new Exception("Unknown enviorment");
            }
        }

        public string Run()
        {
            return _dialog.RenderButton();
        }
    }
}
