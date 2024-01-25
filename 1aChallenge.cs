using System;
					
public class Program
{
	public static void Main()
	{
		//This prints something in the console
		Console.WriteLine("Enter your Name");
		
		//Console.ReadLine is used to ask for user input, specifically for a string, then sets it as a Variable
		string name = Console.ReadLine();
		
		//Using + in this makes it so more than one thing is printed in the console
		Console.WriteLine("Your name is " + name);
		
		Console.WriteLine("Lets do some math! Write a number to multiply by 10");
		
		// using Convert.ToInt32 changes this from a string to an int
		int userNum = Convert.ToInt32(Console.ReadLine());
		
		// i use this to multiply the number the user typed in by 10, then return that value as a variable
		int tenUserNum = userNum * 10;
		
		Console.WriteLine("Ok, you picked " + userNum + ", " + userNum + " times 10 is " + tenUserNum);
		Console.WriteLine("Ok, now lets divide that by something. Type a number to divide " + tenUserNum + " by " + name);
		int userDivNum = Convert.ToInt32(Console.ReadLine());
		
		//using this I can divide the previous number by the new number users inputted.
		int divTenNum = tenUserNum / userDivNum;
		
		Console.WriteLine("Ok, " + name + "y you chose to divide " + tenUserNum + " by " + userDivNum + " which leaves us with " + divTenNum);
		
		//I use this to subtract one from the number previously returned
		int fixNum = --divTenNum;
		Console.WriteLine("Actually, I dont love that number... Let me fix it real quick. Ok, I think that " + fixNum + " looks much better.");
	}
}
