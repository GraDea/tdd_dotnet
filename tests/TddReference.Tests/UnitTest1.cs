using FluentAssertions;

namespace TddReference.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        1.Should().Be(1);
    }

    [Fact]
    public void RedTest()
    {
        0.Should().Be(1);
    }
}