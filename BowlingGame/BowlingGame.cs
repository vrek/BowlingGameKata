using System.Security.Cryptography;

namespace BowlingGameKata;

public class BowlingGame
{
    private int _score = 0;
    private int _frame = 1;

    public IPinDropper Dropper { get; set; } = new PinDropper();

    public static void Main()
    {
        // Entry point logic here
    }

    public void Game()
    {
        _score = 0;
        _frame = 1;
        while (_frame <= 10)
        {
            Frame frame = new();
            _score += frame.PlayFrame(Dropper);
            _frame++;
        }
    }

    

    public int Score()
    {
        return _score;
    }
}
