namespace NumberGuesserLibrary;

public class NumberGuesser
{
    private int low;
    private int high;
    private int lives;
    private int answer;

    public NumberGuesser(int lowerBound, int upperBound, int tries)
    {
        low = lowerBound;
        high = upperBound;
        lives = tries;
        answer = new Random().Next(lowerBound, upperBound + 1);
    }

    private void displayGameParameters()
    {
        System.Console.WriteLine($"Low: { low }, High: { high }, Lives: { lives }");
    }

    private int getUserGuess()
    {
            System.Console.WriteLine("Enter your guess: ");
            int guess = Convert.ToInt16(Console.ReadLine());
            return guess;
    }

    private bool checkLivesLeft()
    {
        return lives > 0;
    }

    private bool checkGuessIsCorrect(int guess)
    {
        return guess == answer;
    }

    public void PlayGame()
    {
        System.Console.WriteLine("Starting game...");
        displayGameParameters();
        System.Console.WriteLine($"Answer: { answer }");

        while (checkLivesLeft())
        {
            int guess = getUserGuess();

            if (checkGuessIsCorrect(guess))
            {
                System.Console.WriteLine("You guessed correct! You win!");
                break;
            }
            else
            {
                lives --;
                System.Console.WriteLine($"You guessed wrong! You have { lives } lives left");
            }
        }
    }
}