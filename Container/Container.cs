using System.Net.NetworkInformation;

namespace Container;

public class Container
{
    public readonly IDictionary<Type, Type> _instances;

    public Container()
    {
        _instances = new Dictionary<Type, Type>();
    }

    public void Register<TInterface, TConcrete>()
    {
        _instances.Add(typeof(TInterface), typeof(TConcrete));
    }

    public object GetInstance<TKey, TValue>()
    {
        var instance = _instances.FirstOrDefault(x => x.Key == typeof(TKey)).Value;
        
        return (TValue)Activator.CreateInstance(instance);
    }
    
}
