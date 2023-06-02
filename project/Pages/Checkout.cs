using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Pages
{
    public class Checkout
    {
        private readonly IPage _page;
        private readonly ILocator _checkoutPage;
        private readonly ILocator _noOfProducts;
        private readonly ILocator _productsCount;
        private readonly ILocator _productRemove;
        private readonly ILocator _moveToCheckout;
        private readonly ILocator _moveToback;


        public Checkout(IPage page, string checkoutPage = "[id='checkout']")
        {
            _page = page;
            _checkoutPage = _page.Locator(checkoutPage);
        }

        public async Task goToCheckform()
        {
            await _checkoutPage.ClickAsync();
        }
    }
}
