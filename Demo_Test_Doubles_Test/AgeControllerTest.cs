using Demo_Test_Doubles.Controllers;
using Demo_Test_Doubles.Interfaces;
using Moq;
using System;
using Xunit;

namespace Demo_Test_Doubles_Test
{
    public class AgeControllerTest
    {
        [Fact]
        public void Get_Returns_Adult()
        {
            var mock = new Mock<IAge>();
            mock.Setup(p => p.Get(19)).Returns("Adult");

            AgeController ageController = new AgeController(mock.Object);
            string result = ageController.Get(19);
            Assert.Equal("Adult", result);
        }
    }
}
