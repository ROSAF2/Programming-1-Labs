using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEmptyString
{
    [TestClass]
    public class UnitTestEmpty
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "";

            //
            string actualResult = Lab27.Program.TitleCase("");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
