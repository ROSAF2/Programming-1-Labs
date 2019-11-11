using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab27
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "Hello World";

            //
            string actualResult = Lab27.Program.TitleCase("hello world");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
