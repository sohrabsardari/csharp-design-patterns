namespace Shipping.ShippingMethods;

public class MerchantShipping : IShipping
{
    public string FragileShipping()
    {
        return "Merchant will send it... with caution";
    }

    public string NormalShipping()
    {
        return "Merchant will send it normally";
    }
}