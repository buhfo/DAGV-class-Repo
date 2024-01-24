using System;
					
public class Program
{
	public static void Main()
	{
		int startNum = 10;
		int addNum = startNum + 70;
		int subNum = addNum - 4;
		int multNum = subNum * 2;
		int divNum = multNum / 3;
		int modNum = divNum % 6;
		int incNum = modNum ++;
		int decNum = incNum --;
		
		int x = 8;
		x += startNum;
		
		
		if (x > 0 && startNum < 100);
			Console.WriteLine("it works!");
		
		Console.WriteLine(startNum +" "+ addNum +" "+ subNum +" "+ multNum +" "+ divNum +" "+ modNum +" "+ incNum +" "+ decNum + " and " + x);
	}
}
