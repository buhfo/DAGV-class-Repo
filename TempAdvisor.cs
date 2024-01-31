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
		else
		{
			Console.WriteLine("Enjoy the pleasant weather!");
		}
		
		
	}
}
