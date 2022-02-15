using FluentAssertions;
using Shipping.ShippingFactory;
using Xunit;

namespace Shipping.Tests
{
    public class FragileItemTests
    {
        [Fact]
        public void Send_fragile_item_with_our_shipping_method()
        {
            var fragileItem = new OurShippingFactory();
            var fragileShippingMethod = fragileItem.CreateShippingMethod();

            var shippingResult = fragileShippingMethod.FragileShipping();

            shippingResult.Should().Be("We will send it... with caution");
        }

        [Fact]
        public void Send_fragile_item_with_merchant_shipping_method()
        {
            var fragileItem = new MerchantShippingFactory();
            var fragileShippingMethod = fragileItem.CreateShippingMethod();

            var shippingResult = fragileShippingMethod.FragileShipping();

            shippingResult.Should().Be("Merchant will send it... with caution");
        }
    }
}
