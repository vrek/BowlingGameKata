using BowlingGameKata;

namespace TestBowlingGame;

public class PassingTest
{
    private BowlingGame _game;

    public PassingTest()
    {
        _game = new BowlingGame();
    }

    //private void RollMany(int pins, int rolls)
    //{
    //    for (var i = 0; i < 20; i++)
    //    {
    //        _game.Roll(pins);
    //    }
    //}

    [Fact]
    public void GivenAGameOfAllZeroShouldReturnAZeroScore()
    {


        var pins = 0;
        var rolls = 20;
        //RollMany(pins, rolls);
        Assert.Equal(0, _game.Score());
    }

    [Fact]
    public void GivenAGameOfAllOneShouldReturnATwentyScore()
    {
        var pins = 1;
        var rolls = 20;
        //RollMany(pins, rolls);
        Assert.Equal(20, _game.Score());
    }
}