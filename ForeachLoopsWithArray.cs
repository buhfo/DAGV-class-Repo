using System;
					
public class Program
{
	public static void Main()
	{
		string[] games = {"Half-life", "Halo", "Pokemon", "Minecraft"};
		foreach(var game in games){
			Console.WriteLine("I love " + game);
		}
	}
}
