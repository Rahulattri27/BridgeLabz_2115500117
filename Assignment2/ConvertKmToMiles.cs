using System;
class ConvertKmToMiles{
	// taking input from user and converting kilometers to miles
	public static void KiloMetersToMiles(){
		// taking input from user
		Console.Write("Enter the distance in km: ");
		double km = Convert.ToDouble(Console.ReadLine());
		double miles=km/1.6;
		//printing the km in miles
		Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
	}
	static void Main(string[] args){
		KiloMetersToMiles();
	}
}