using OpenQA.Selenium;
using Xunit;

namespace SeleniumTest
{
    public class UnitTest3 : BaseTest 
    {

        [Fact]
        public void Test7()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                var res = driver.FindElement(By.Id("lst-ib"));
				Assert.True(res != null);
			}
        }

        [Fact]
        public void Test8()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                var res = driver.FindElement(By.Id("lst-ib"));
				Assert.True(res != null);
			}
        }

        [Fact]
        public void Test9()
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
