namespace CSharp.Basics;

public class Lasagna
{
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => PreparationTimeInMinutes(layers) + minutesInOven;

    public int ExpectedMinutesInOven() => 40;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;
}