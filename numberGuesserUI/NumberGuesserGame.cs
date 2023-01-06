using NumberGuesserLibrary;

namespace MainGame;

class Game
{
    static void Main(string[] args)
    {
        NumberGuesser game = new NumberGuesser(0, 10, 3);
        game.PlayGame();
    }
}