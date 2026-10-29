namespace BowlingGame.Tests;

public class GameTests
{
    [Fact]
    public void Test1()
    {
        var game = new Game();
        var rolls = new int[20]; 
        
        Assert.Equal(0, game.Score(rolls));
    }
}