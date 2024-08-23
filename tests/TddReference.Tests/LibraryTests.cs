using FluentAssertions;
using TddReference.WebAPI.Domain;

namespace TddReference.Tests;

public class LibraryTests
{
    [Fact]
    public void Library_is_empty_and_closed_on_start()
    {
        var library = new Library();

        library.Readers.Count.Should().Be(0);
        library.IsClosed.Should().BeTrue();
    }
    [Fact]
    public void Library_can_open()
    {
        var library = new Library();

        library.Open();

        library.IsClosed.Should().BeFalse();
    }
}