using Euler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace EulerUnitTests
{
    
    
    /// <summary>
    ///This is a test class for Problem1Test and is intended
    ///to contain all Problem1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Problem1Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SumTheMultiplesOf3And5
        ///</summary>
        [TestMethod()]
        public void SumTheMultiplesOf3And5Test()
        {
            int limit = 10;
            int expected = 23;
            int actual;
            actual = Problem1.SumTheMultiplesOf3And5(limit);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///A test for SumTheMultiplesOf3And5 speed
        ///</summary>
        [TestMethod()]
        public void SumTheMultiplesOf3And5PerformanceTest()
        {
            int limit = 1000;
            int time_limit = 10;//miliseconds
            Stopwatch sw = Stopwatch.StartNew();
            Problem1.SumTheMultiplesOf3And5(limit);
            sw.Stop();
            Assert.IsTrue(sw.Elapsed.TotalMilliseconds < time_limit);
        }
    }
}
