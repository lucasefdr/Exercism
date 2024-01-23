using CSharp.Strings;
using Xunit;

namespace CSharpTest.Strings;

public class BobTests
{
    [Fact]
    public void Stating_something()
    {
        Assert.Equal("Whatever.", Bob.Response("Tom-ay-to, tom-aaaah-to."));
    }

    [Fact]
    public void Shouting()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("WATCH OUT!"));
    }

    [Fact]
    public void Shouting_gibberish()
    {
        Assert.Equal("Whoa, chill out!", Bob.Response("FCECDFCAAB"));
    }

    [Fact]
    public void Asking_a_question()
    {
        Assert.Equal("Sure.", Bob.Response("Does this cryogenic chamber make me look fat?"));
    }
}