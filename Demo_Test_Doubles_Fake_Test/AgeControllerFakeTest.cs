using Demo_Test_Doubles.Controllers;
using System;
using Xunit;

namespace Demo_Test_Doubles_Fake_Test
{
    public class AgeControllerFakeTest
    {
        [Fact]
        public void Get_Fake_Returns_Minor()
        {
            Fakeclass fakeClass = new Fakeclass();
            AgeController ageController = new AgeController(fakeClass);

            string result = ageController.Get(17);
            Assert.Equal("Minor Age", result);
        }
    }
}
