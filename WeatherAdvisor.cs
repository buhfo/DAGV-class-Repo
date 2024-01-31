using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("What is the current temperature in Celsius?");
		
		// this sets up currentTemp as a user input, and Convert.ToInt32 changes the string to an interger
		int currentTemp = Convert.ToInt32(Console.ReadLine());
		
		//this checks the number you entered, and gives a response based off of that.
		if (currentTemp > 30)
		{
			Console.WriteLine("Looks like its pretty hot! Stay hydrated, and avoid staying in the sun for too long.");
		}
		else if (currentTemp < 30 && currentTemp > 20)
		{
			Console.WriteLine("Enjoy the pleasant weather!");
		}
		else if (currentTemp < 20 && currentTemp > 10)
		{
			Console.WriteLine("Seems a little chilly, I recommend a light jacket.");
		}
		else if (currentTemp < 10 && currentTemp > 0)
		{
			Console.WriteLine("Pretty cold! Be sure to layer up quite a bit!");
		}
		else if (currentTemp < 0)
		{
			Console.WriteLine("WOW! Thats so cold! You might want to stay inside.");
		}
	}
}
