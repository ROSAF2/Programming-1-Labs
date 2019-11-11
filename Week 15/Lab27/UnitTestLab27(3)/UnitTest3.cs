using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab27_3_
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "The Quick Brown Fox Jumps Over The Lazy Dog.";

            //
            string actualResult = Lab27.Program.TitleCase("The quick brown fox jumps over the lazy dog.");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
