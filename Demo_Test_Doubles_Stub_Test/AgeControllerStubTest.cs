using Demo_Test_Doubles.Controllers;
using System;
using Xunit;

namespace Demo_Test_Doubles_Stub_Test
{
    public class AgeControllerStubTest
    {
        [Fact]
        public void Age_Returns_Minor_Age()
        {
            StubClass stubClass = new StubClass();
            AgeController ageController = new AgeController(stubClass);

            string result = ageController.Get(17);
            Assert.Equal("Minor Age", result);
        }
    }
}
