namespace CSharp.Strings;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().EndsWith('?'))
            return IsYelling(statement) ? "Calm down, I know what I'm doing!" : "Sure.";

        return IsYelling(statement) ? "Whoa, chill out!" : "Whatever.";
    }

    static bool IsYelling(string input)
    {
        var isLetter = false;

        foreach (char c in input)
        {
            if (char.IsLetter(c) && char.IsLower(c)) return false;

            if (char.IsLetter(c)) isLetter = true;
        }

        return isLetter;
    }
}
