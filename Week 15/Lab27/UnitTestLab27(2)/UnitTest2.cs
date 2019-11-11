using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLab27_2_
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "Hola!, Me Llamo Francisco";

            //
            string actualResult = Lab27.Program.TitleCase("Hola!, me llamo Francisco");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
