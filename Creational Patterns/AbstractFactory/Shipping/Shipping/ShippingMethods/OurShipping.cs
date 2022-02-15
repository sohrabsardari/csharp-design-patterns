namespace Shipping.ShippingMethods;

public class OurShipping:IShipping
{
    public string FragileShipping()
    {
        return "We will send it... with caution";
    }

    public string NormalShipping()
    {
        return "We will send it normally";
    }
}