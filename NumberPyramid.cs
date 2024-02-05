using System;
					
public class Program
{
	public static void Main()
	{
		int i, j;
		Console.WriteLine("Hi, how many layers would you like your pyramid to be?");
		
		// this sets the number of layers
		int playerNumber = Convert.ToInt32(Console.ReadLine());
	
		//this is what makes sure we stop at the final layer
		for (i = 0; i <= playerNumber; i++)
		{	//this repeats the number as many times as the current layer, then moves till the next layer
			for (j = 1; j <= i ; j++)
				Console.Write(i);
			Console.Write("\n");
		}
	}
} 
