using System;
class Height{
	// converting the height from cm to foots and inches
	public static void HeightConvert(){
		//taking height from user
		Console.Write("Enter your height in cms: ");
		double cms = Convert.ToDouble(Console.ReadLine());
		double inches= cms/2.54;
		double foots= inches/12;
		//printing the user heights
		Console.WriteLine($"Your Height in cm is {cms} while in feet is {foots} and inches is {inches}");
	}
	static void Main(string[] args){
		HeightConvert();
	}
}