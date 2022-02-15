using FluentAssertions;
using Shipping.ShippingFactory;
using Xunit;

namespace Shipping.Tests;

public class NormalItemTests
{
    [Fact]
    public void Send_normal_item_with_our_shipping_method()
    {
        var fragileItem = new OurShippingFactory();
        var fragileShippingMethod = fragileItem.CreateShippingMethod();

        var shippingResult = fragileShippingMethod.NormalShipping();

        shippingResult.Should().Be("We will send it normally");
    }

    [Fact]
    public void Send_fragile_item_with_merchant_shipping_method()
    {
        var fragileItem = new MerchantShippingFactory();
        var fragileShippingMethod = fragileItem.CreateShippingMethod();

        var shippingResult = fragileShippingMethod.NormalShipping();

        shippingResult.Should().Be("Merchant will send it normally");
    }
}