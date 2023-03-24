using Microsoft.VisualStudio.TestTools.UnitTesting;
using weatherClientTool;
namespace weatherClientToolTest
{
    [TestClass]
    public class WeatherTest
    {
        [TestMethod]
        public void WeatherSuccessTest()
        {
            double latitude =28.6600;
            double lognitude = 77.2300;
            WeatherInformation weatherInformation = new WeatherInformation();
            //Act
            weatherInformation.GetWeatherInfo(latitude, lognitude).GetAwaiter().GetResult();
            Assert.IsTrue(true);
        }
    }
}