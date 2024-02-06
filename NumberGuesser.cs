using System;
					
public class Program
{
	public void Main()
	{
		new NumberGuesser();
		NumberGuesser.numGuess();
	}
}


public class NumberGuesser
{
	private static Random rnd = new Random();
	public static void numGuess()
	{	
		bool answeredRight = false;
		int guess;
		int number = GetRandom();
		int guesses;
		while (answeredRight == false)
		{
			guess = 0;
			guesses = 0;
			
			while (guess != number)
			{
				guess = 0;
				Console.WriteLine("Guess a number between " + 1 + "-" + 10);
				guess = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Guess: " + guess);
				
				if (guess != number)
				{
					guess = 0;
					Console.WriteLine("Nope! Guess again!");
				}
				guesses++;
				
			}
			Console.WriteLine("Congrats! " + number + " is the right number!");
			Console.WriteLine("It took you " + guesses + " guesses");
			answeredRight = true;
		}
	}
	public static int GetRandom()
        {
            return rnd.Next( 1,  11);
        }
}
