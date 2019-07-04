using Microsoft.VisualStudio.TestTools.UnitTesting;
using labs_22_first_test;

namespace Tests_MSTEST
{
    [TestClass]
    public class MSTests
    {
        [TestMethod]
        public void SumTotalofArrayTest()
        {
            // arrange
            int[] myArray = { 10, 20, 30 };
            var expected = 3;
            // act
            var actual = LabWork.SumTotalofArrayMembers(myArray);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
