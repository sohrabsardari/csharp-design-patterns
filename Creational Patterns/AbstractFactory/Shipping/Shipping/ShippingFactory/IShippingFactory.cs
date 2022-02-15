using Shipping.ShippingMethods;

namespace Shipping.ShippingFactory;

public interface IShippingFactory
{
    IShipping CreateShippingMethod();
}