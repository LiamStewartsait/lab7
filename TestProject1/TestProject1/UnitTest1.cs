namespace TestProject1
{
    public class BasicMathTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2,4,6)]
        public void Test_AddMethod(double x, double y, double expected)
        {
            double actual = BasicMath.BasicMath.add(x,y);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        [TestCase(4, 2, 2)]
        public void Test_SubtractMethod(double x, double y, double expected)
        {
            double actual = BasicMath.BasicMath.subtract(x, y);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        [TestCase(2, 4, 8)]
        public void Test_MultiplyMethod(double x, double y, double expected)
        {
            double actual = BasicMath.BasicMath.multiply(x, y);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        [TestCase(10, 2, 5)]
        public void Test_DivideMethod(double x, double y, double expected)
        {
            double actual = BasicMath.BasicMath.devide(x, y);
            Assert.AreEqual(actual, expected);
        }


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}