using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Pages
{
    public class OrderDetails
    {
        private readonly IPage _page;
        private readonly ILocator _FinishPage;

        public OrderDetails(IPage page, string finish = "#finish")
        {
            _page = page;
            _FinishPage = _page.Locator(finish);
        }

        public async Task goToFinish()
        {
            await _FinishPage.ClickAsync();
        }

    }
}
