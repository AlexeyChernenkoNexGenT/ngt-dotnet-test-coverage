using Xunit;

namespace Math.Tests
{
    public class MathTests
    {
        readonly Numbers.Class1 _service;

        public MathTests() => _service = new Numbers.Class1();

        [Fact]
        public void Should_Add() => Assert.Equal(3, _service.AddOrSubtract(1, 2, true));
    }
}
