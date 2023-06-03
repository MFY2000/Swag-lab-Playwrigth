using Allure.Net.Commons;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Helper
{
    public class ScreenShot
    {
        public static async Task take(IPage page, string details, Status status = Status.passed)
        {
            byte[] bytes = await page.ScreenshotAsync();
            AllureLifecycle.Instance.AddAttachment(details, "image/png", bytes);
        }



    }
}
