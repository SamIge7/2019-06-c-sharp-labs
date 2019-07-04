using NUnit.Framework;
using labs_22_first_test;
using Tests;
using static Tests.Eng35Tests;

namespace Tests
{
    public class NUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubeNumbersTest(int x, int y, int z, int expected)
        {
            // arrange
            var instance = new LabWork();
            // act
            var actual = instance.CubeNumbers(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubenumbersStaticTest(int x, int y, int z, int expected)
        {
            // arrange
            // act
            var actual = LabWork.CubeNumbersStatic(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 300, 500 }, 5)]
        [TestCase(new int[] { 1, 2, 3, -10, -30, -50 }, 6)]
        public void ArrayLengthTest(int[] testArray, int expected)
        {
            // act
            var actual = LabWork.GetLengthOfArray(testArray);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, -1)]
        public void Mega_Multiple_Coding_Loop(int[] array, int expected)
        {
            //arrange

            //act
            var actual = Eng35Tests.Mega_Multiple_Coding_Loop(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 }, 325)]
        public void ReturnSumOfArray(int[] array, int expected)
        {
            var actual = Eng35Tests.SumOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 4, 4, 65536.0d)]
        public void ExponentialTest(int x, int y, int n, double expected)
        {
            var exp = new Eng35Tests();
            var actual = Eng35Tests.Exponential(x, y, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 6, 3 }, new int[] { 1, 3, 6 })]
        public void SortedArrayTest(int[] array, int[] expected)
        {
            var actual = Eng35Tests.SortArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,10,4,2)]
        public void DivisibleTest(int start, int end, int divisor, int expected)
        {
            var actual = Eng35Tests.How_Many_Numbers_Divisible_By(start, end, divisor);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10,20,30,40},1012)]
        public void ArrayQueueStackTest (int[] array, int expected)
        {
            var actual = Eng35Tests.Array_Loop_Queue_Stack(array);
            Assert.AreEqual(expected, actual);
        }
    }
}