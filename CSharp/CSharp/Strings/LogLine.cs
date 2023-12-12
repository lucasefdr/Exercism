namespace CSharp.Strings;

public static class LogLine
{
    public static string Message(string logLine) => logLine.Split(": ")[1];

    public static string LogLevel(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}

