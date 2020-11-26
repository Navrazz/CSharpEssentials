
using Creational.AbstractFactory.Components;

namespace Creational.AbstractFactory.Dialogs
{
    public interface IDialog
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
