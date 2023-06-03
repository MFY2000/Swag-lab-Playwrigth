using Allure.Net.Commons;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Playwright_PageTest001;

namespace ST_Testing_SwagLab
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTesting : PageTest
    {
        [SetUp]
        [AllureBefore("Test Init")]
        public async Task Setup()
        {
            Console.WriteLine("Test Setup");
            await ScreenShot.take(Page, "Test Init Setup");
        }

        [TearDown]
        [AllureAfter("Test Clean")]
        public async Task TearDown()
        {
            Console.WriteLine("Test Cleanup");
            await ScreenShot.take(Page, "Test Clean Method");
            await Page.CloseAsync();
        }


        [Test]
        [AllureStep]
        [AllureEpic("")]
        [AllureFeature("")]
        [AllureStory("")]
        [AllureOwner("MUhammad Fahad")]
        [AllureDescription("")]
        [Category("Allure")]
        [AllureTag("NUnit", "Debug", "Booking")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureId(123)]
        [AllureTms("Defect 54 ", "https://dev.azure.com/DemoOrganizationAI/DemoAgileProject/_workitems/edit/54")]
        [AllureSuite("Booking Suite")]
        [AllureLink("TestCase 38", "https://dev.azure.com/DemoOrganizationAI/DemoAgileProject/_workitems/edit/38")]
        public async Task HappyFlow()
        {
            try
            {

            await Page.GotoAsync("https://www.saucedemo.com/");

            LoginPage login = new LoginPage(Page);
            await login.Login("standard_user", "secret_sauce");

            AddToCart cart = new AddToCart(Page);
            await cart.addProuctToCart();
            await cart.goToCheckout();

            Checkout checkout = new Checkout(Page);
            await checkout.goToCheckform();
            
            checkoutForm checkoutForm = new checkoutForm(Page);
            await checkoutForm.fillForm();

            OrderDetails orderDetails = new OrderDetails(Page);
            await orderDetails.goToFinish();
            }
            catch
            {

            }



        }
    }

    [TestFixture]
    public class ExtentRpeort : PageTest
    {
        [OneTimeSetUp]
        public async Task ClassInit()
        {

        }

        [OneTimeTearDown]
        public async Task ClassCleanUp()
        {

        }

        [SetUp]
        public async Task TestSetup()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.CurrentContext.Test.MethodName);
        }

        [TearDown]
        public async Task TearDown()
        {

        }

        [Test]

        public async Task HappyFlow()
        {
            try
            {

                await Page.GotoAsync("https://www.saucedemo.com/");

                LoginPage login = new LoginPage(Page);
                await login.Login("standard_user", "secret_sauce");

                AddToCart cart = new AddToCart(Page);
                await cart.addProuctToCart();
                await cart.goToCheckout();

                Checkout checkout = new Checkout(Page);
                await checkout.goToCheckform();

                checkoutForm checkoutForm = new checkoutForm(Page);
                await checkoutForm.fillForm();

                OrderDetails orderDetails = new OrderDetails(Page);
                await orderDetails.goToFinish();
            }
            catch
            {

            }
        }

        public async Task Test001()
        {
            try
            {

                await Page.GotoAsync("https://www.saucedemo.com/");

                LoginPage login = new LoginPage(Page);
                await login.Login("standard_user", "secret_sauce");
            }
            catch
            {

            }
        }
        public async Task Test002()
        {
            try
            {

                await Page.GotoAsync("https://www.saucedemo.com/");

                LoginPage login = new LoginPage(Page);
                await login.Login("standard_uer", "secret_sauce");
                var respone = await Page.Locator(".error-message-container").InnerTextAsync();
                Assert.AreEqual(respone, "abs fndsln", "Test failed");
                ExtentReport.TakeScreenshot(Page, "Screen Shot take");
            }
            catch
            {

            }
        }

    }

    public class AssemblyInitialize
    {
        [SetUpFixture]
        public class Setup
        {
            [OneTimeSetUp]
            public static void AssemblyLevelSetup()
            {
                // Create Extent Report
                ExtentReport.LogReport("TestReport");
            }

            [OneTimeTearDown]
            public static void AssemblyLevelTearDown()
            {
                ExtentReport.extentReports.Flush();
            }
        }
    }
}