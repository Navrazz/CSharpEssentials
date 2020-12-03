
namespace Creational.Prototype.Model
{
    public interface ICloneable<T> where T : class
    {
        T ShallowCopy();
        T DeepCopy();
    }
}
