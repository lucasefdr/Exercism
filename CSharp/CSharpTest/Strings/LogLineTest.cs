using CSharp.Strings;
using Xunit;

namespace CSharpTest.Strings;

public class LogLineTest
{
    [Fact]
    void Message_ReturnsMessageFromALogLine()
    {
        // ARRANGE
        var fullMessage = "[ERROR]: Invalid operation";
        var message = "Invalid operation";

        // ACT
        var result = LogLine.Message(fullMessage);

        // ASSERT
        Assert.Equal(message, result);
    }

    [Fact]
    void LogLevel_ReturnsLineLogLevel()
    {
        // ARRANGE
        var fullMessage = "[ERROR]: Invalid operation";
        var logLineMessage = "error";

        // ACT
        var result = LogLine.LogLevel(fullMessage);

        // ASSERT
        Assert.Equal(logLineMessage, result);
    }

    [Fact]
    void Reformat_ReturnsLogLineFormatted()
    {
        // ARRANGE 
        var logLine = "[INFO]: Operation completed";
        var logLineFormatted = "Operation completed (info)";

        // ACT
        var result = LogLine.Reformat(logLine);

        // ASSERT
        Assert.Equal(logLineFormatted, result);
    }
}