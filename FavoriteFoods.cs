using System;
					
public class Program
{
	public static void Main()
	{	
		Console.WriteLine("Hi, whats your favorite food?");
		string []food = new string[3];
		for(int i = 0;i<food.Length;i++)
		{
    		food[i]= Console.ReadLine();
			if (i < food.Length - 1)
			{
				Console.WriteLine("Your next favorite?");
			}
		}
		
		Console.WriteLine(food[0] + "? I love " + food[0]);
		Console.WriteLine(food[1] + "? I dont know... I guess  " + food[1] + " is alright.");
		Console.WriteLine(food[2] + "? I agree,  " + food[2] + " goes so hard.");
	}
}
