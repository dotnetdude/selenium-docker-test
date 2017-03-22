using OpenQA.Selenium;
using Xunit;

namespace SeleniumTest
{
    public class UnitTest2 : BaseTest 
    {

        [Fact]
        public void Test4()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                var res = driver.FindElement(By.Id("lst-ib"));
				Assert.True(res != null);
			}
        }

        [Fact]
        public void Test5()
        {
            using (var driver = GetDriver())
			{
				driver.Navigate().GoToUrl(Url);
                var res = driver.FindElement(By.Id("lst-ib"));
				Assert.True(res != null);
			}
        }

        [Fact]
        public void Test6()
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
