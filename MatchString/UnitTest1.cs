using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatchString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareKnownGood1()
        {
            // Arrange - setup the test data
            string s1 = "eat";
            string s2 = "tea";

            // Act
            bool result = MatchString.Match(s1, s2);

            // Assert 
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CompareKnownGood2()
        {
            // Arrange - setup the test data
            string s1 = "eat";
            string s2 = "ate";

            // Act
            bool result = MatchString.Match(s1, s2);

            // Assert 
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CompareKnownBad()
        {
            // Arrange - setup the test data
            string s1 = "eat";
            string s2 = "tee";

            // Act
            bool result = MatchString.Match(s1, s2);

            // Assert 
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CompareUnequalLengths()
        {
            // Arrange - setup the test data
            string s1 = "eat";
            string s2 = "teas";

            // Act
            bool result = MatchString.Match(s1, s2);

            // Assert 
            Assert.IsFalse(result);
        }
    }
}
