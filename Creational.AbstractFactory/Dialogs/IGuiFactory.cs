using Creational.AbstractFactory.Components;

namespace Creational.AbstractFactory.Dialogs
{
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
