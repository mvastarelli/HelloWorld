using Xunit;

namespace HelloWorld.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator calc = new Calculator();

        [Fact]
        public void TestAdd()
        {
            Assert.Equal(2, calc.Add(1, 1));
        }

        [Fact]
        public void TestSub()
        {
            Assert.Equal(0, calc.Sub(1, 1));
        }

        [Fact]
        public void TestMul()
        {
            Assert.Equal(4, calc.Mul(2, 2));
        }

        [Fact]
        public void TestDiv()
        {
            Assert.Equal(2, calc.Div(4, 2));
        }
    }
}
