using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab27_5_
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "Reality Hits You Hard Brah";

            //
            string actualResult = Lab27.Program.TitleCase("REALITY HITS YOU HARD BRAH");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
