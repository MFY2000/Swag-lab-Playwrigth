using Azure;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Pages
{
    
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly ILocator _usename;
        private readonly ILocator _password;
        private readonly ILocator _button;


        public LoginPage(IPage page, string usename = "#user-name", string password = "#password", string button = "#login-button")
        {
            _page = page;
            _usename = _page.Locator(usename);
            _password = _page.Locator(password);
            _button = _page.Locator(button);
        }


        public async Task Login(string usenameTxt, string passwordTxt) 
        {
            try
            {
                await _usename.FillAsync(usenameTxt);
                await _password.FillAsync(passwordTxt);
                await _button.ClickAsync();
            }
            catch
            {
                Console.Write("error in login");
            }
        }
        
        public async Task isLogin()
        {
            /*await _page.GetByText(".error-message-container");*/
        }

        public async Task Logout()
        {

        }

    }
}
