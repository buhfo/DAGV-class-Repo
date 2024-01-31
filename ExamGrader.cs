using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter the score you got on your most recent exam.");
		
		// Gets a user input, and changes it to an interger
		int userScore = Convert.ToInt32(Console.ReadLine());
		
		// Checks for an A
		if (userScore > 90 && userScore < 100 )
		{
			Console.WriteLine("You got an A. Great work! Keep it up.");
		}
		// Checks for a B
		else if (userScore > 80 && userScore < 90 )
		{
			Console.WriteLine("You got a B. Great work! It could be better though, study up.");
		}
		//Checks for a C
		else if (userScore > 70 && userScore < 80 )
		{
			Console.WriteLine("You got a C. Its not the end of the world, but be sure to study more.");
		}
		//Checks for a D
		else if (userScore > 60 && userScore < 70 )
		{
			Console.WriteLine("You got a D. Woof. Thats a failing grade. Study harder next time!");
		}
		//Checks for a F
		else if (userScore < 60 )
		{
			Console.WriteLine("You got a F. Woof. Thats a failing grade. Study harder next time! Dont give up though!");
		}
		// checks for any grade exceeding an A
		else if (userScore > 100 )
		{
			Console.WriteLine("Wow! You got an A, and some extra credit! Congrats!");
		}
	}
}
