using CSharp.Basics;
using Xunit;

namespace CSharpTest.Basics;

public class LasagnaTest
{
    private readonly Lasagna lasagna;

    public LasagnaTest()
    {
        lasagna = new Lasagna();
    }

    [Fact]
    void ExpectedMinutesInOven_ReturnsExpectedTime()
    {
        // ARRANGE
        var expectedMinutes = 40;

        // ACT
        var result = lasagna.ExpectedMinutesInOven();

        // ASSERT
        Assert.Equal(expectedMinutes, result);
    }

    [Theory]
    [InlineData(20)]
    [InlineData(10)]
    [InlineData(30)]
    void RemainingMinutesInOven_ReturnsCorrectRemainingTime(int minutesInOven)
    {
        // ARRANGE
        var expectedMinutes = 40;
        var remainingTime = expectedMinutes - minutesInOven;

        // ACT
        var result = lasagna.RemainingMinutesInOven(minutesInOven);

        // ASSERT
        Assert.Equal(remainingTime, result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    void PreparationTimeInMinutes_ReturnsTimeByLayers(int layers)
    {
        // ARRANGE
        var timeByLayer = 2;
        var timeInMinutes = layers * timeByLayer;

        // ACT
        var result = lasagna.PreparationTimeInMinutes(layers);

        // ASSERT
        Assert.Equal(timeInMinutes, result);
    }

    [Theory]
    [InlineData(2, 10)]
    [InlineData(4, 20)]
    [InlineData(6, 10)]
    void ElapsedTimeInMinutes_ReturnsTimeInCooking(int layers, int minutesInOven)
    {
        // ARRANGE
        var timeByLayer = layers * 2;
        var elapsedTimeInMinutes = timeByLayer + minutesInOven;
        
        // ACT
        var result = lasagna.ElapsedTimeInMinutes(layers, minutesInOven);

        // ASSERT
        Assert.Equal(elapsedTimeInMinutes, result);
    }
}
