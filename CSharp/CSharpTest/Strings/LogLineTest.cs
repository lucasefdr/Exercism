using CSharp.Strings;
using Xunit;

namespace CSharpTest.Strings;

public class LogLineTest
{
    [Fact]
    void GetMessageFromALogLine()
    {
        Assert.Equal("Stack overflow", LogLine.Message("[ERROR]: Stack overflow"));
    }
}