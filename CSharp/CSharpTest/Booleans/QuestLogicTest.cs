using CSharp.Boolean;
using Xunit;

namespace CSharpTest.Booleans;

public class QuestLogicTest
{
    [Fact]
    void CanFastAttack_ReturnsTrueIfKinghtIsNotAwake()
    {
        // ARRANGE
        bool knightIsAwake = false;

        // ACT
        bool result = QuestLogic.CanFastAttack(knightIsAwake);

        // ASSERT
        Assert.True(result);
    }

    [Fact]
    void CanFastAttack_ReturnsFalseIfKinghtIsAwake()
    {
        // ARRANGE
        bool knightIsAwake = true;

        // ACT
        bool result = QuestLogic.CanFastAttack(knightIsAwake);

        // ASSERT
        Assert.False(result);
    }

    [Theory]
    [InlineData(true, false, false)]
    [InlineData(false, true, false)]
    [InlineData(false, false, true)]
    void CanSpy_ReturnsTrueIfAtLeastOneOfThemIsAwake(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // ARRANGE + ACT
        bool result = QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);

        // ASSERT
        Assert.True(result);
    }

    [Fact]
    void CanSignalPrisoner_ReturnsTrueIfArchersIsNotAwakeAndPrisonerIsAwake()
    {
        // ARRANGE
        bool archerIsAwake = false;
        bool prisonerIsAwake = true;

        // ACT
        bool result = QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);

        // ASSERT
        Assert.True(result);
    }

    [Theory]
    [InlineData(true, false, true, true)]
    [InlineData(false, false, true, false)]
    void CanFreePrisoner_ReturnsTrue(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // ARRANGE + ACT
        bool result = QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);

        // ASSERT
        Assert.True(result);
    }

}
