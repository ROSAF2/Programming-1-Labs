using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab27_4_
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "1234567890 !@#$%^&*() \"unit Test\"";

            //
            string actualResult = Lab27.Program.TitleCase("1234567890 !@#$%^&*() \"unit Test\"");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
