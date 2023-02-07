namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // EXERCISE 1 //

            int favNumber = 15;
            Console.WriteLine("Guess my favorite number between 1 and 100");
            int userGuess = 0;

             string GuessingGame()
            {
                var userGuess = int.Parse(Console.ReadLine());

                if (userGuess == 015)
                {
                    Console.WriteLine("Wow! You guessed it right. Good job!");

                }
                else if (userGuess > 0 && userGuess < 15) 
                {
                    Console.WriteLine("Your need to guess a higher number!");
                }

                else if (userGuess > 15)
                {
                    Console.WriteLine("You need to guess a lower number!");
                }

                else
                {
                    Console.WriteLine("That is a value I don't recognize!");
                }

                return  "To beginning";
               
            }

            GuessingGame();

            do
            {
                GuessingGame();
            } while (userGuess != 15 );



        }
    }
}
