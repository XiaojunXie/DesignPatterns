// As per the definition of the Factory Method Design Pattern, we need to create an abstract class or interface for creating the object. 

using SimpleFactory;

namespace FactoryMethod;

public abstract class CreditCardFactory
{
    protected abstract CreditCard MakeProduct();

    public CreditCard CreateProduct()
    {
        return MakeProduct();
    }
}