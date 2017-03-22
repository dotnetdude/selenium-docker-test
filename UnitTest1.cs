using OpenQA.Selenium;
using Xunit;

namespace SeleniumTest
{
    public class UnitTest1 : BaseTest 
    {
        [Fact]
        public void TakeScreenShot()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("screenshot" + System.DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".jpeg" ,ScreenshotImageFormat.Jpeg);
			}
        }

        [Fact]
        public void Test2()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                var res = driver.FindElement(By.Id("lst-ib"));
				Assert.True(res != null);
			}
        }

        [Fact]
        public void Test3()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                var res = driver.FindElement(By.Id("lst-ib"));
				Assert.True(res != null);
			}
        }
    }
}