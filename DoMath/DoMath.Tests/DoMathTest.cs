using NUnit.Framework;

#region Version 1
/*namespace DoMath.Tests
{
    [TestFixture]
    public class DoMathTest
    {
            [Test]
            public void ShouldAdd2Numbers()
            {
                IDoMath idm = new Math();   
                int expectedResult = idm.Add(7, 8); 
                Assert.That(expectedResult, Is.EqualTo(15));  
        }

            [Test]
            public void ShouldMultiply2Numbers()
            {
                IDoMath idm = new Math();
                int expectedResult = idm.Multiply(7, 8);
                Assert.That(expectedResult, Is.EqualTo(56));
            }
    }
}
*/
#endregion
#region Verion 2

namespace DoMath.Tests
{
    [TestFixture]
    public class DoMathTest
    {
        IDoMath idm;
        [SetUp]
        public void TestSetUp()
        {
            idm = new Math();
        }
        [Test]
        public void ShouldAdd2Numbers()
        {

            int expectedResult = idm.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }
        [Test]
        [Ignore("Test ignored until Monday")]
        public void ShouldMultiply2Numbers()
        {

            int expectedResult = idm.Multiply(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }
        [TearDown]
        public void TestTearDown()
        {
            idm = null;
        }
    }
}
#endregion