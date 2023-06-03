using Azure;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Pages
{
    public class checkoutForm
    {
        private readonly IPage _page;
        private readonly ILocator _first;
        private readonly ILocator _second;
        private readonly ILocator _postal;
        private readonly ILocator _continue;


        public checkoutForm(IPage page, string first = "#first-name", string last = "#last-name",string postal = "#postal-code",string btn = "#continue")
        {
            _page = page;
            _first = _page.Locator(first);
            _second = _page.Locator(last);
            _postal = _page.Locator(postal);
            _continue = _page.Locator(btn);
        }

        public async Task fillForm()
        {
            await _first.FillAsync("Ahsan");
            await _second.FillAsync("Mansoori");
            await _postal.FillAsync( "23456");
            await _continue.ClickAsync();
        }

    }
}
