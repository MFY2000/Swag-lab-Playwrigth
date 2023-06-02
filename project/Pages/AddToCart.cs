using Microsoft.Playwright;
using project.Constant;

namespace project.Pages
{
    public class AddToCart
    {
        private readonly IPage _page;
        private readonly ILocator _productId;
        private readonly ILocator _productCount;
        private readonly ILocator _productremove;


        public AddToCart(IPage page, String productId = "[name = 'add-to-cart-sauce-labs-backpack']", string productCount = ".shopping_cart_link")
        {
            _page = page;
            _productId = _page.Locator(productId);
            _productCount = _page.Locator(productCount);
        }


        public async Task addProuctToCart()
        {
            await _productId.ClickAsync();
        }

        public async Task goToCheckout()
        {
            await _productCount.ClickAsync();
        }


        public async Task isProductAdded(String count = "1")
        {
            var respones = await _productCount.InnerTextAsync();
            if(respones != count)
            {
                /*Assert.That(respones, Is.EqualTo(count), ContantsFile.msg(pageNmae: "Add to Cart"));*/
            }
        }


        public async Task removeCartProduct()
        {
            await _productremove.ClickAsync();
        }
    }
}
