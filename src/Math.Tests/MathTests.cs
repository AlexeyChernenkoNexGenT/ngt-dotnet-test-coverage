using Xunit;

namespace Math.Tests
{
    public class MathTests
    {
        readonly Numbers.Class1 _service;

        public MathTests() => _service = new Numbers.Class1();

        [Fact]
        public void Should_Add() => Assert.Equal(3, _service.AddOrSubtract(1, 2, true));

        [Fact]
        public void Should_Subtract() => Assert.Equal(1, _service.AddOrSubtract(2, 1, false));

        [Fact]
        public void Should_Multiply() => Assert.Equal(4, _service.MultiplyOfDivide(2, 2, true));

        [Fact]
        public void Should_Divide() => Assert.Equal(2, _service.MultiplyOfDivide(4, 2, false));
    }
}
