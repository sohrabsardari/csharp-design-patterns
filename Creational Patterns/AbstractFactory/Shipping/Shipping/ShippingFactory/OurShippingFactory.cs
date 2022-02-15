using Shipping.ShippingMethods;

namespace Shipping.ShippingFactory;

public class OurShippingFactory: IShippingFactory
{
    public IShipping CreateShippingMethod()
    {
        return new OurShipping();
    }
}