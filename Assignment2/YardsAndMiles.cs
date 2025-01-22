using System;
class YardsAndMiles{
	//method to convert distance from feet to yards and miles
	static void Distance(){
		//taking feet as input from user
		Console.Write("Enter the distance in feet: ");
		double feet = Convert.ToDouble(Console.ReadLine());
		double yard = feet / 3;
		double miles = yard / 1760;
		//Printing the distances in feets,yards,miles
		Console.WriteLine($"Your Distance in feet is {feet} and in yard is {yard} and in mile is {miles} ");
	}
	static void Main(string[] args){
		Distance();
	}	
}