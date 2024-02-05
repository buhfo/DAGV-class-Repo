using System;
					
public class Program
{
	public static void Main()
	{
		string[] books = {"Catcher in the Rye", "Dracula", "Dune"};
		for(var i = 0; i < books.Length; i++){
			Console.WriteLine(books[i]);
			books[i] = "Pretty good.";
			Console.WriteLine(books[i]);			
		}
	}
}
