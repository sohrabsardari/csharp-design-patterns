using Shipping.ShippingMethods;

namespace Shipping.ShippingFactory;

public class MerchantShippingFactory : IShippingFactory
{
    public IShipping CreateShippingMethod()
    {
        return new MerchantShipping();
    }
}