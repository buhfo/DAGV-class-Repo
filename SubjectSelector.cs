using System;
					
public class Program
{
	public static void Main()
	{
		string courseAdvice = "";
		string scoreReview = "";
		Console.WriteLine("Hi, enter in the subject youre having trouble with.");
		
		string userSubject = Console.ReadLine();
		
		Console.WriteLine("Ok, what is the most recent score youve gotten on a test?");
		
		int userScore = Convert.ToInt32(Console.ReadLine());
		
	
		// Checks for a B
		if (userScore > 80 && userScore < 90 )
		{
			scoreReview = "You got a B. Great work! It could be better though, study up.";
		}
		//Checks for a C
		else if (userScore > 70 && userScore < 80 )
		{
			scoreReview = "You got a C. Its not the end of the world, but be sure to study more.";
		}
		//Checks for a D
		else if (userScore > 60 && userScore < 70 )
		{
			scoreReview = "You got a D. Woof. Thats a failing grade. Study harder next time!";
		}
		//Checks for a F
		else if (userScore < 60 )
		{
			scoreReview = "You got a F. Woof. Thats a failing grade. Study harder next time! Dont give up though!";
		}
		// checks for any grade exceeding an A
		else if (userScore > 100 )
		{
			scoreReview = "Wow! You got an A, and some extra credit! Congrats!";
		}
		
		// this checks if the grade is even worth giving advice on, if its too high it just gives a general keep it up, otherwise it gets specific
		if (userScore > 90)
		{
			Console.WriteLine("You scored pretty high, just keep up with what youve been doing!");
			scoreReview = "";
			courseAdvice = "";
		}
		else
		{	
			switch(userSubject)
			{
				case "math":
					courseAdvice = " Be sure to memorize all of the formulas youll need to use!";
					break;
				case "science":
					courseAdvice = " Memorize formulas, and any other key terms.";
					break;
				case "english":
					courseAdvice = " Go slow and steady, if your issue is writing, have someone review your work. For reading, make sure you go slow and steady and read it more than once.";
					break;
				case "history":
					courseAdvice = " Make sure you spend time memorizing names of events and people, and also dates associated.";
					break;
				case "lunch":
					courseAdvice = " Why do you even have a grade for lunch?";
					break;
			}
		}
		
		Console.WriteLine(scoreReview + courseAdvice);
		
	}
}







